using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class Color
    {
        [XmlAttribute("sid")]
        public string Id { get; set; }
        [XmlText]
        public string Value { get; set; }
    }
}
