using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    [XmlRoot("player")]
    public class Intro : BaseCommand
    {
        public string name { get; set; }

        public Intro() { }

        public Intro(string name)
        {
            this.name = name;
            Id = 2;
        }

    }
}
