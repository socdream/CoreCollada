using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class Node
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("name")]
        public string Name { get; set; }

        [XmlAttribute("layer")]
        public string Layer { get; set; }

        [XmlAttribute("sid")]
        public string SId { get; set; }

        [XmlElement("matrix")]
        public string Matrix { get; set; }

        [XmlElement("node")]
        public List<Node> Nodes { get; set; }

        [XmlElement("instance_controller")]
        public InstanceController InstanceController { get; set; }

        [XmlElement("instance_geometry")]
        public InstanceGeometry InstanceGeometry { get; set; }

        private float[] _matrixValue;
        public float[] MatrixValue
        {
            get
            {
                if (Matrix == null)
                    return null;

                if (_matrixValue != null)
                    return _matrixValue;

                _matrixValue = Matrix
                    .Replace("\r\n", " ")
                    .Replace("\r", " ")
                    .Replace("\n", " ")
                    .Replace("  ", " ")
                    .Split(' ')
                    .Where(a => !string.IsNullOrWhiteSpace(a))
                    .Select(a => float.Parse(a, CultureInfo.InvariantCulture))
                    .ToArray();

                return _matrixValue;
            }
        }
    }
}
