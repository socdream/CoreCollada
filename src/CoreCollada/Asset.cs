using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class Asset
    {
        [XmlElement("created")]
        public string Created { get; set; }
        [XmlElement("keywords")]
        public string Keywords { get; set; }
        [XmlElement("modified")]
        public string Modified { get; set; }
        [XmlElement("revision")]
        public string Revision { get; set; }
        [XmlElement("subject")]
        public string Subject { get; set; }
        [XmlElement("title")]
        public string Title { get; set; }
        [XmlElement("unit")]
        public Unit Unit { get; set; }
        [XmlElement("up_axis")]
        public string UpAxis { get; set; }
    }
}
