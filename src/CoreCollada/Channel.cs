using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class Channel
    {
        [XmlAttribute("source")]
        public string Source { get; set; }
        [XmlAttribute("target")]
        public string Target { get; set; }
    }
}
