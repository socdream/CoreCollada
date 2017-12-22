using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class Input
    {
        [XmlAttribute("semantic")]
        public string Semantic { get; set; }
        [XmlAttribute("source")]
        public string Source { get; set; }
        [XmlAttribute("offset")]
        public int Offset { get; set; } = 0;
        [XmlAttribute("set")]
        public string Set { get; set; }
    }
}
