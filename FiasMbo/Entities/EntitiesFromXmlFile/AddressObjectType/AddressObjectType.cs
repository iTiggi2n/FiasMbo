using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.AddressObjectType
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "AddressObjectType", IsNullable = true)]
    public class AddressObjectType
    {
        [XmlAttribute("KOD_T_ST")]
        public string KOD_T_ST { get; set; }
        [XmlAttribute("SOCRNAME")]
        public string SOCRNAME { get; set; }
        [XmlAttribute("LEVEL")]
        public string LEVEL { get; set; }
        [XmlAttribute("SCNAME")]
        public string SCNAME { get; set; }
    }
}
