using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class TechniqueCommon
    {
        [XmlElement("accessor")]
        public List<Accessor> Accessor { get; set; }
        [XmlElement("instance_material")]
        public List<InstanceMaterial> InstanceMaterials { get; set; }
    }
}
