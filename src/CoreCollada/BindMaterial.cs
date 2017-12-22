using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class BindMaterial
    {
        [XmlElement("technique_common")]
        public TechniqueCommon TechniqueCommon { get; set; }
    }
}
