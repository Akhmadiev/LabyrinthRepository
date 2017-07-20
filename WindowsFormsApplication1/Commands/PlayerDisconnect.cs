using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    [XmlRoot("player_disconnect")]
    public class PlayerDisconnect : BaseCommand
    {
        public PlayerDisconnect() { Id = 12; }        
    }
}
