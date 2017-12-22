using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class Texture
    {
        [XmlAttribute("texture")]
        public string Image { get; set; }
        [XmlAttribute("texcoord")]
        public string TexCoord { get; set; }
    }
}
