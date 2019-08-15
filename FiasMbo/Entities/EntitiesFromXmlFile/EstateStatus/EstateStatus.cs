using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.EstateStatus
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "EstateStatus", IsNullable = true)]
    public class EstateStatus
    {
        [XmlAttribute("NAME")]
        public string NAME { get; set; }
        [XmlAttribute("ESTSTATID")]
        public string ESTSTATID { get; set; }
    }
}
