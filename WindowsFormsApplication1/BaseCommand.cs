using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    public class BaseCommand
    {
        [XmlAttribute ("id")]
        public int Id { get; set; }

        public static Type[] Types =
        {
            typeof (Response), typeof (Intro), typeof (PlayerList), typeof (Chat),
            typeof (TimeLeft), typeof (PlayerCoords), typeof (MapSize), typeof (VisibleObjects), typeof (VisiblePlayers),
            typeof (PlayerMove), typeof (GameOver), typeof (PlayerDisconnect),
        };

        public BaseCommand(int id)
        {
            Id = id;
        }

        public BaseCommand()
        { }

        public string Serialize()
        {
            XmlSerializer formatter = new XmlSerializer(GetType());
            StringBuilder command = new StringBuilder();           

            using (StringWriter writer = new StringWriter())
            {
                formatter.Serialize(writer, this);
                string xml = writer.ToString();
                command.Append((char)Id);
                command.Append((char)xml.Length);
                command.Append(xml);
                return command.ToString();
            }
        }

        public static BaseCommand Deserialize(int id, string xml)
        {
            try
            {
                XmlSerializer formatter = new XmlSerializer(Types[id - 1]);
                StringReader reader = new StringReader(xml);
                return (BaseCommand) formatter.Deserialize(reader);                
            }
            catch (Exception e)
            {
                Errors.AppendError(e.Message);
                return null;
            }            
        }


    }
}
