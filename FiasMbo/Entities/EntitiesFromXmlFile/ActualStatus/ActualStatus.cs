using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.ActualStatus
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "ActualStatus", IsNullable = true)]
    public class ActualStatus
    {
        [XmlAttribute("ACTSTATID")]
        public string ACTSTATID { get; set; }
        [XmlAttribute("NAME")]
        public string NAME { get; set; }
    }
}
