using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class Mesh
    {
        [XmlElement("source")]
        public List<Source> Sources { get; set; }

        [XmlElement("vertices")]
        public Vertices Vertices { get; set; }

        [XmlElement("triangles")]
        public List<Triangles> Triangles { get; set; }
    }
}
