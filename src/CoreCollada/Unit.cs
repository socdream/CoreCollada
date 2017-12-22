using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class Unit
    {
        [XmlAttribute("meter")]
        public float Meter { get; set; }
        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}
