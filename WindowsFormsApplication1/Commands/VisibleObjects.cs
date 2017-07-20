using System.Collections.Generic;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    [XmlRoot("visible_objects")]
    public class VisibleObjects : BaseCommand
    {
        [XmlArray("map_objects")]
        [XmlArrayItem("map_object")]
        public List<MapObject> map_objects { get; set; }

        public VisibleObjects() { }

        public VisibleObjects(List<MapObject> map_objects)
        {            
            this.map_objects = map_objects;
            Id = 8;
        }
    }
}
