using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.StructureStatus
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "StructureStatus", IsNullable = true)]
    public class StructureStatus
    {
        [XmlAttribute("STRSTATID")]
        public string STRSTATID { get; set; }
        [XmlAttribute("NAME")]
        public string NAME { get; set; }
    }
}
