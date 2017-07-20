using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    [XmlRoot("player_coords")]
    public class PlayerCoords : BaseCommand
    {
        public int row { get; set; }

        public int col { get; set; }

        public PlayerCoords() { }

        public PlayerCoords(int row, int col)
        {            
            this.row = row;
            this.col = col;
            Id = 6;
        }
    }
}
