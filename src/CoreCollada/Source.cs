using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class Source
    {
        [XmlAttribute("id")]
        public string Id { get; set; }
        [XmlElement("float_array")]
        public string FloatArray { get; set; }
        [XmlElement("Name_array")]
        public string NameArray { get; set; }
        [XmlElement("technique_common")]
        public TechniqueCommon TechniqueCommon { get; set; }

        private float[] _floatValues;
        public float[] FloatValues
        {
            get
            {
                if (_floatValues != null)
                    return _floatValues;

                _floatValues = FloatArray
                    .Replace("\r\n", " ")
                    .Replace("\r", " ")
                    .Replace("\n", " ")
                    .Replace("  ", " ")
                    .Split(' ')
                    .Where(a => !string.IsNullOrWhiteSpace(a))
                    .Select(a => float.Parse(a, CultureInfo.InvariantCulture))
                    .ToArray();

                return _floatValues;
            }
        }

        private string[] _nameValues;
        public string[] NameValues
        {
            get
            {
                if (_nameValues != null)
                    return _nameValues;

                _nameValues = NameArray
                    .Replace("\r\n", " ")
                    .Replace("\r", " ")
                    .Replace("\n", " ")
                    .Replace("  ", " ")
                    .Split(' ')
                    .Where(a => !string.IsNullOrWhiteSpace(a))
                    .ToArray();

                return _nameValues;
            }
        }
    }
}
