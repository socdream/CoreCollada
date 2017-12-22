using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoreCollada
{
    // http://www.wazim.com/Collada_Tutorial_1.htm
    [XmlRoot(ElementName = "COLLADA", Namespace = "http://www.collada.org/2005/11/COLLADASchema")]
    public class Collada
    {
        [XmlElement(ElementName = "asset")]
        public Asset Asset { get; set; }

        [XmlArray("library_images")]
        [XmlArrayItem("image")]
        public List<Image> LibraryImages { get; set; }

        [XmlArray("library_materials")]
        [XmlArrayItem("material")]
        public List<Material> LibraryMaterials { get; set; }

        [XmlArray("library_geometries")]
        [XmlArrayItem("geometry")]
        public List<Geometry> LibraryGeometries { get; set; }

        [XmlArray("library_controllers")]
        [XmlArrayItem("controller")]
        public List<Controller> LibraryControllers { get; set; }

        [XmlArray("library_lights")]
        [XmlArrayItem("light")]
        public List<Light> LibraryLights { get; set; }

        [XmlArray("library_visual_scenes")]
        [XmlArrayItem("visual_scene")]
        public List<VisualScene> LibraryVisualScenes { get; set; }

        [XmlArray("library_animations")]
        [XmlArrayItem("animation")]
        public List<Animation> LibraryAnimations { get; set; }

        [XmlArray("library_effects")]
        [XmlArrayItem("effect")]
        public List<Effect> LibraryEffects { get; set; }

    }
}
