using System.Collections.Generic;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    [XmlRoot("player_list")]
    public class PlayerList : BaseCommand
    {
        [XmlArray("players")]
        [XmlArrayItem("player")]
        public List<Player> players { get; set; }

        public PlayerList() { }

        public PlayerList(List<Player> players)
        {            
            this.players = players;
            Id = 3;
        }

    }
}
