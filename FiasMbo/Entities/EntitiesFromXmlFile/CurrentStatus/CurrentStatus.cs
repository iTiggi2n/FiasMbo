using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.CurrentStatus
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "CurrentStatus", IsNullable = true)]
    public class CurrentStatus
    {
        [XmlAttribute("CURENTSTID")]
        public string CURENTSTID { get; set; }
        [XmlAttribute("NAME")]
        public string NAME { get; set; }
    }
}
