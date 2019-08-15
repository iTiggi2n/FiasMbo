using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.IntervalStatus
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "IntervalStatus", IsNullable = true)]
    public class IntervalStatus
    {
        [XmlAttribute("NAME")]
        public string NAME { get; set; }
        [XmlAttribute("INTVSTATID")]
        public string INTVSTATID { get; set; }
    }
}
