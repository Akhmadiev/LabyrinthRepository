using System.Collections.Generic;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    [XmlRoot("visible_players")]
    public class VisiblePlayers : BaseCommand
    {
        [XmlArray("players")]
        [XmlArrayItem("player")]
        public List<VisiblePlayer> players { get; set; }
        
        public VisiblePlayers() { }

        public VisiblePlayers(List<VisiblePlayer> players)
        {
            this.players = players;
            Id = 9;
        }
    }
}
