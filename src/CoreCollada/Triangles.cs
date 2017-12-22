using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class Triangles
    {
        [XmlAttribute("count")]
        public int Count { get; set; }
        [XmlAttribute("material")]
        public string Material { get; set; }
        [XmlElement("input")]
        public List<Input> Inputs { get; set; }
        [XmlElement("p")]
        public string P { get; set; }

        private int[] _values;
        public int[] Values
        {
            get
            {
                if (_values != null)
                    return _values;

                _values = P
                    .Replace("\r\n", " ")
                    .Replace("\r", " ")
                    .Replace("\n", " ")
                    .Replace("  ", " ")
                    .Split(' ')
                    .Where(a => !string.IsNullOrWhiteSpace(a))
                    .Select(a => int.Parse(a))
                    .ToArray();

                return _values;
            }
        }
    }
}
