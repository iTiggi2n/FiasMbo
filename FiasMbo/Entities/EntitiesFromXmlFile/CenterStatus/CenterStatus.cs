using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.CenterStatus
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "CenterStatus", IsNullable = true)]
    public class CenterStatus
    {
        [XmlAttribute("CENTERSTID")]
        public string CENTERSTID { get; set; }
        [XmlAttribute("NAME")]
        public string NAME { get; set; }
    }
}
