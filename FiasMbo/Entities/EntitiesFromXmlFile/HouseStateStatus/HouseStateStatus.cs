using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.HouseStateStatus
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "HouseStateStatus", IsNullable = true)]
    public class HouseStateStatus
    {
        [XmlAttribute("HOUSESTID")]
        public string HOUSESTID { get; set; }
        [XmlAttribute("NAME")]
        public string NAME { get; set; }
    }
}
