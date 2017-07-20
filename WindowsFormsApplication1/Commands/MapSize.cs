using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    [XmlRoot("map_size")]
    public class MapSize : BaseCommand
    {

        public int width { get; set; }

        public int height { get; set; }        

        public MapSize() { }

        public MapSize(int width, int height)
        {            
            this.width = width;
            this.height = height;
            Id = 7;
        }

    }
}
