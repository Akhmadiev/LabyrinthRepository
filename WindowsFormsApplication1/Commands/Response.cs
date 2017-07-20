using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    [XmlRoot ("response")]
    public class Response : BaseCommand
    {

        public string text { get; set; }

        public Response() { }       

        public Response(string text)
        {
            this.text = text;
            Id = 1;
        }
    }
}
