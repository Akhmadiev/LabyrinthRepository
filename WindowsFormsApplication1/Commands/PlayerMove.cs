using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    [XmlRoot("player_move")]
    public class PlayerMove : BaseCommand
    {
        public string direction { get; set; }

        public PlayerMove() { }

        public PlayerMove(string direction)
        {
            this.direction = direction;
            Id = 10;
        }
    }
}
