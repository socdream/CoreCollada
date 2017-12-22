using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class InstanceMaterial
    {
        [XmlAttribute("symbol")]
        public string Symbol { get; set; }
        [XmlAttribute("target")]
        public string Target { get; set; }
    }
}
