using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace WindowsFormsApplication1
{
    class Connection
    {
        private Socket sender;
        private IPEndPoint ipEndPoint;
        StringBuilder response;
        Thread _thread;

        public delegate void GettingMesage();
        public GettingMesage GetMes;

        public Connection(string ip, int port)
        {            
            IPAddress ipAddr = IPAddress.Parse(ip);
            ipEndPoint = new IPEndPoint(ipAddr, port);
            sender = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            response = new StringBuilder();

            OpenConnect();
            Start();

        }

        public bool OpenConnect()
        {
            try
            {
                sender.Connect(ipEndPoint);
            }
            catch (Exception e)
            {
                Errors.AppendError(e.Message);
                return false;
            }
            return true;
        }

        public bool CloseConnect()
        {
            try
            {                
                sender.Close();

            }
            catch (Exception e)
            {
                Errors.AppendError(e.Message);
                return false;
            }
            return true;
        }

        public bool CheckStatus()
        {
            try
            {
                return sender.Connected;
            }
            catch (Exception e)
            {
                Errors.AppendError(e.Message);
            }
            return false;
        }

        public bool CheckBuffer()
        {
            try
            {
                return sender.ReceiveBufferSize > 0;
            }
            catch (Exception e)
            {
                Errors.AppendError(e.Message);
            }
            return false;
        }

        public bool Send(string message)
        {
            try
            {
                byte[] msg = Encoding.Unicode.GetBytes(message);
                int bytesSent = sender.Send(msg);
                if (bytesSent != msg.Length)
                {
                    Errors.AppendError("Не все данные отправлены");
                    return false;
                }
            }
            catch (Exception e)
            {
                Errors.AppendError(e.Message);
            }
            return true;
        }

        public string Receive()
        {
            string text;
            lock (response)
            {
                text = response.ToString();
                response.Clear();
            }
            return text;
        }

        private void GetMessage()
        {
            try
            {
                byte[] bytes = new byte[1024];                

                while (true)
                {                   

                    int bytesRec = sender.Receive(bytes);
                    if (bytesRec == 0)
                    {                        
                        Errors.AppendError("Server disconnected.");
                        break;
                    }
                    lock (response)
                    {
                        response.Append(Encoding.Unicode.GetString(bytes, 0, bytesRec));
                    }
                    
                    GetMes();
                }
            }
            catch (ThreadAbortException te)
            {
                Errors.AppendError(te.Message);
            }
            catch (Exception e)
            {
                Errors.AppendError(e.Message);
            }
        }

        public int CountReceivedBuffer()
        {
            try
            {
                return sender.ReceiveBufferSize;
            }
            catch (Exception e)
            {
                Errors.AppendError(e.Message);
            }
            return 0;
        }


        public bool Start()
        {
            try
            {
                _thread = new Thread(delegate() { GetMessage(); });
                _thread.Start();
            }
            catch (Exception e)
            {
                Errors.AppendError(e.Message);
                return false;
            }
            return true;
        }
    }
}
