using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    public class Skin
    {
        [XmlAttribute("source")]
        public string Source { get; set; }

        [XmlElement("bind_shape_matrix")]
        public string BindShapeMatrix { get; set; }

        [XmlElement("source")]
        public List<Source> Sources { get; set; }

        [XmlArray("joints")]
        [XmlArrayItem("input")]
        public List<Input> Joints { get; set; }

        [XmlElement("vertex_weights")]
        public VertexWeights VertexWeights { get; set; }

        private float[] _bindShapeMatrixValue;
        /// <summary>
        /// A single matrix that represents the transform of the bind-shape at the time when
        /// the mesh was bound to a skeleton.This matrix transforms the bind-shape from object space to
        /// bind-space.
        /// </summary>
        public float[] BindShapeMatrixValue
        {
            get
            {
                if (_bindShapeMatrixValue != null)
                    return _bindShapeMatrixValue;

                _bindShapeMatrixValue = BindShapeMatrix
                    .Replace("\r\n", " ")
                    .Replace("\r", " ")
                    .Replace("\n", " ")
                    .Replace("  ", " ")
                    .Split(' ')
                    .Where(a => !string.IsNullOrWhiteSpace(a))
                    .Select(a => float.Parse(a, CultureInfo.InvariantCulture))
                    .ToArray();

                return _bindShapeMatrixValue;
            }
        }
    }
}
