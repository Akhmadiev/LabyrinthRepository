using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    [XmlRoot("game_over")]
    public class GameOver : BaseCommand
    {
        public int result { get; set; }

        public GameOver() { }

        public GameOver(int result)
        {
            this.result = result;
            Id = 11;
        }
    }
}
