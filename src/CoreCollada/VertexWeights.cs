using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class VertexWeights
    {
        [XmlAttribute("count")]
        public int Count { get; set; }
        [XmlElement("input")]
        public List<Input> Inputs { get; set; }
        [XmlElement("vcount")]
        public string VCount { get; set; }
        [XmlElement("v")]
        public string V { get; set; }
        
        private int[] _vCountValue;
        public int[] VCountValue
        {
            get
            {
                if (_vCountValue != null)
                    return _vCountValue;

                _vCountValue = VCount
                    .Replace("\r\n", " ")
                    .Replace("\r", " ")
                    .Replace("\n", " ")
                    .Replace("  ", " ")
                    .Split(' ')
                    .Where(a => !string.IsNullOrWhiteSpace(a))
                    .Select(a => int.Parse(a))
                    .ToArray();

                return _vCountValue;
            }
        }

        private int[] _vValue;
        public int[] VValue
        {
            get
            {
                if (_vValue != null)
                    return _vValue;

                _vValue = V
                    .Replace("\r\n", " ")
                    .Replace("\r", " ")
                    .Replace("\n", " ")
                    .Replace("  ", " ")
                    .Split(' ')
                    .Where(a => !string.IsNullOrWhiteSpace(a))
                    .Select(a => int.Parse(a))
                    .ToArray();

                return _vValue;
            }
        }
    }
}
