using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace WindowsFormsApplication1
{

    class Commands : Connection
    {
        AutoResetEvent evt;
        public delegate void Receive();
        public Receive ReceiveMsg;

        private StringBuilder buffer;
        private Queue<BaseCommand> send_buffer;
        private Queue<BaseCommand> receive_buffer;


        public Commands(string ip, int port)
            : base(ip, port)
        {
            buffer = new StringBuilder();
            receive_buffer = new Queue<BaseCommand>();
            send_buffer = new Queue<BaseCommand>();

            evt = new AutoResetEvent(false);

            GetMes = ReceiveResponse;

            ThreadStart();
        }

        private void ReceiveResponse()
        {
            string text = Receive();

            if (text.Length > 0)
            {
                lock (buffer)
                {
                    buffer.Append(text);
                }
                evt.Set();
            }
        }

        public bool Send(BaseCommand cmd)
        {
            try
            {
                lock (send_buffer)
                {
                    send_buffer.Enqueue(cmd);
                }
                evt.Set();
            }
            catch (Exception e)
            {
                Errors.AppendError(e.Message);
            }            

            return true;
        }

        private void HandleBuffer()
        {
            while (true)
            {
                if (evt.WaitOne())
                {
                    if (send_buffer.Count > 0)
                    {
                        while (send_buffer.Count > 0)
                        {
                            lock (send_buffer)
                            {
                                Send(send_buffer.Dequeue().Serialize());
                            }
                        }
                    }
                    else
                    {
                        do
                        {
                            string queue;
                            lock (buffer)
                            {
                                queue = buffer.ToString();
                            }                                                           
                            if (queue.Length < 2)
                                break;

                            int idCommand = queue[0];
                            int lenght = queue[1];

                            string text = string.Empty;

                            if (queue.Length >= lenght + 2)
                                text = queue.Substring(2, lenght);
                            else
                                break;

                            buffer.Remove(0, lenght + 2);

                            receive_buffer.Enqueue(BaseCommand.Deserialize(idCommand, text));

                            ReceiveMsg();
                        }
                        while (buffer.Length > 0);
                    }
                }
            }
        }

        public BaseCommand ReceiveCommand()
        {
            BaseCommand cmd;
            lock (receive_buffer)
            {
                cmd = receive_buffer.Dequeue();
            }
            return cmd;
        }

        private bool ThreadStart()
        {
            try
            {
                new Thread(delegate() { HandleBuffer(); }).Start();
            }
            catch (Exception e)
            {
                Errors.AppendError(e.Message);
            }
            return true;
        }


    }
}
