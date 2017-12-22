using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class Technique
    {
        [XmlElement("phong")]
        public PhongTechnique Phong { get; set; }
    }
}
