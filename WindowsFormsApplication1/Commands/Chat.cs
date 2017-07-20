using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    [XmlRoot("message")]
    public class Chat : BaseCommand
    {
        public string sender { get; set; }
        public string text { get; set; }

        public Chat() { }

        public Chat(string sender, string text)
        {
            Id = 4;
            this.text = text;
            this.sender = sender;
        }
    }
}