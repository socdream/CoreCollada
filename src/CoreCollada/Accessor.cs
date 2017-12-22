using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class Accessor
    {
        [XmlAttribute("source")]
        public string Source { get; set; }
        [XmlAttribute("count")]
        public int Count { get; set; }
        [XmlAttribute("stride")]
        public int Stride { get; set; }
        [XmlElement("param")]
        public List<Param> Params { get; set; }
    }
}
