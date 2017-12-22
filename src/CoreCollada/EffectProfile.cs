using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class EffectProfile
    {
        [XmlElement("technique")]
        public Technique Technique { get; set; }
    }
}
