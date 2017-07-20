using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    [XmlRoot("time_left")]
    public class TimeLeft : BaseCommand
    {

        public decimal time { get; set; }

        public TimeLeft() { }

        public TimeLeft(decimal time)
        {
            this.time = time;
            Id = 5;
        }
    }
}
