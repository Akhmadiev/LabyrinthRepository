using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class GameForm : Form
    {
        private string name, server;
        private int port;
        private bool start;
                
        private Commands _command;
        private GameData _gameData;
        private decimal dateTime;

        public GameForm(string name, int port, string server)
        {
            this.name = name;
            this.port = port;
            this.server = server;            

            InitializeComponent();
        }

        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {                  
            _command = new Commands(server, port);            
            _command.Send(new Intro(name));
            _command.ReceiveMsg = Receive;

            _gameData = new GameData();
            _gameData.name = name;
        }

        private void sendMsgTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                _command.Send(new Chat(name, sendMsgTextBox.Text));                
            }
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            _command.Send(new PlayerDisconnect());
            this.Close();
            //_command.CloseConnect();
        }

        private void PlaceGame_Paint(object sender, PaintEventArgs e)
        {
            if (start)
            {
                //_gameData.Draw(e.Graphics);
            }
        }

        private void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (start)
            {
                _command.Send(new PlayerMove(_gameData.Move(e)));
            }
        }

        private void Receive()
        {
            CheckForIllegalCrossThreadCalls = false;
            var cmd = _command.ReceiveCommand();
            switch ((Enums.Commands) cmd.Id)
            {
                case Enums.Commands.Chat:
                    Chat chat = (Chat) cmd;
                    ChatRichText.AppendText(chat.sender + ": " + chat.text + "\n");
                    sendMsgTextBox.Clear();
                    break;

                case Enums.Commands.Response:
                    Response intro = (Response) cmd;
                    ChatRichText.AppendText("SERVER: " + intro.text + "\n");
                    break;

                case Enums.Commands.PlayerList:
                    PlayerList playerList = (PlayerList) cmd;
                    Helping.PlayerList(playerList, playersRichTextBox);
                    _gameData.playerList = playerList;
                    break;

                case Enums.Commands.TimeLeft:
                    timerGame.Tick += TimerGame_Tick;

                    TimeLeft time = (TimeLeft)cmd;
                    dateTime = time.time;

                    timerGame.Interval = 1000;
                    timerGame.Start();
                    //TimeLeft time = (TimeLeft) cmd;
                    //timeLabel.Text = Helping.TimeLeft(time.time);
                    break;

                case Enums.Commands.MapSize:
                    MapSize mapSize = (MapSize) cmd;
                    _gameData.mapSize = mapSize;
                    _gameData.width = formGame.Width;
                    _gameData.height = formGame.Height;                    
                    break;

                case Enums.Commands.PlayerCoords:
                    _gameData.playerCoords = (PlayerCoords) cmd;
                    break;

                case Enums.Commands.VisibleObjects:
                    _gameData.visibleObjects = (VisibleObjects) cmd;
                    start = true;
                    formGame.Invalidate();
                    break;

                case Enums.Commands.VisiblePlayers:
                    _gameData.visiblePlayers = (VisiblePlayers) cmd;
                    break;

                case Enums.Commands.GameOver:                    
                    MessageBox.Show("GAME OVER", "Сообщение", MessageBoxButtons.OK);
                    _command.CloseConnect();
                    this.Close();                    
                    break;
            }
        }

        private void TimerGame_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = (dateTime - 1).ToString();
        }

        public void ErrorsHandler(string error)
        {
            ChatRichText.AppendText("SERVER: " + error + "\n");
        }


    }
}
