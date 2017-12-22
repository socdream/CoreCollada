using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class Sampler
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlElement("input")]
        public List<Input> Inputs { get; set; }
    }
}
