using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromFiFile.AdditionalAddressInfo
{
    [Serializable]
    [XmlRoot(Namespace = "http://www.v8.1c.ru/ssl/AddressSystem", ElementName = "AdditionalAddressInfo", IsNullable = true)]
    public class AdditionalAddressInfo
    {
        [XmlAttribute("EXTRAGUID")]
        public string ExtraGuid { get; set; }
        [XmlAttribute("REGIONCODE")]
        public string RegionCode { get; set; }
        [XmlAttribute("POSTALCODE")]
        public string PostalCode { get; set; }
        [XmlAttribute("TERRIFNSUL")]
        public string TerrifNSUL{ get; set; }
        [XmlAttribute("TERRIFNSFL")]
        public string TerrifNSFL { get; set; }
        [XmlAttribute("IFNSUL")]
        public string IfNSUL { get; set; }
        [XmlAttribute("IFNSFL")]
        public string IfNSF { get; set; }
        [XmlAttribute("OKTMO")]
        public string OKTMO { get; set; }
        [XmlAttribute("OKATO")]
        public string OKATO { get; set; }
    }
}
