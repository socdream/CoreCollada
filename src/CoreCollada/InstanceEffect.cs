using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class InstanceEffect
    {
        [XmlAttribute("url")]
        public string Url { get; set; }
    }
}
