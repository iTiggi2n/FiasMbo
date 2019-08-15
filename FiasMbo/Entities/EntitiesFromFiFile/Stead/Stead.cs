using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromFiFile.Stead
{
    [Serializable]
    [XmlRoot(Namespace = "http://www.v8.1c.ru/ssl/AddressSystem", ElementName = "Stead", IsNullable = true)]
    public class Stead
    {
        [XmlAttribute("NUMBER")]
        public string NUMBER { get; set; }
        [XmlAttribute("EXTRAGUID")]
        public string EXTRAGUID { get; set; }
        [XmlAttribute("PARENTGUID")]
        public string PARENTGUID { get; set; }
    }
}
