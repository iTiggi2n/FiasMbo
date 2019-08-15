using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromFiFile.House
{
    [Serializable]
    [XmlRoot(Namespace = "http://www.v8.1c.ru/ssl/AddressSystem", ElementName = "House", IsNullable = true)]
    public class House
    {
        [XmlAttribute("EXTRAGUID")]
        public string EXTRAGUID { get; set; }
        [XmlAttribute("AOGUID")]
        public string AOGUID { get; set; }
        [XmlAttribute("BUILDINGS")]
        public string BUILDINGS { get; set; }
    }
}
