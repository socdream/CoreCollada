using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class PhongTechniqueDiffuse
    {
        [XmlElement("texture")]
        public Texture Texture { get; set; }
    }
}
