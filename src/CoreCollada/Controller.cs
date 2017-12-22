using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class Controller
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlElement("skin")]
        public Skin Skin { get; set; }
    }
}
