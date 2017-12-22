using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class AnimationItem
    {
        [XmlElement("source")]
        public List<Source> Sources { get; set; }
        [XmlElement("sampler")]
        public List<Sampler> Samplers { get; set; }
        [XmlElement("channel")]
        public List<Channel> Channels { get; set; }
    }
}
