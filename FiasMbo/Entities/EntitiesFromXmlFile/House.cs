using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "House", IsNullable = true)]
    public class House
    {
        #region properties
        [XmlAttribute("HOUSEID")]
        public string HOUSEID { get; set; }
        [XmlAttribute("HOUSEGUID")]
        public string HOUSEGUID { get; set; }
        [XmlAttribute("AOGUID")]
        public string AOGUID { get; set; }
        [XmlAttribute("HOUSENUM")]
        public string HOUSENUM { get; set; }
        [XmlAttribute("STRSTATUS")]
        public string STRSTATUS { get; set; }
        [XmlAttribute("ESTSTATUS")]
        public string ESTSTATUS { get; set; }
        [XmlAttribute("STATSTATUS")]
        public string STATSTATUS { get; set; }
        [XmlAttribute("IFNSFL")]
        public string IFNSFL { get; set; }
        [XmlAttribute("IFNSUL")]
        public string IFNSUL { get; set; }
        [XmlAttribute("OKATO")]
        public string OKATO { get; set; }
        [XmlAttribute("OKTMO")]
        public string OKTMO { get; set; }
        [XmlAttribute("POSTALCODE")]
        public string POSTALCODE { get; set; }
        [XmlAttribute("STARTDATE")]
        public string STARTDATE { get; set; }
        [XmlAttribute("ENDDATE")]
        public string ENDDATE { get; set; }
        [XmlAttribute("UPDATEDATE")]
        public string UPDATEDATE { get; set; }
        [XmlAttribute("COUNTER")]
        public string COUNTER { get; set; }
        [XmlAttribute("NORMDOC")]
        public string NORMDOC { get; set; }
        [XmlAttribute("CADNUM")]
        public string CADNUM { get; set; }
        [XmlAttribute("DIVTYPE")]
        public string DIVTYPE { get; set; }
        [XmlAttribute("REGIONCODE")]
        public string REGIONCODE { get; set; }
        [XmlAttribute("TERRIFNSFL")]
        public string TERRIFNSFL { get; set; }
        [XmlAttribute("TERRIFNSUL")]
        public string TERRIFNSUL { get; set; }
        [XmlAttribute("STRUCNUM")]
        public string STRUCNUM { get; set; }
        [XmlAttribute("BUILDNUM")]
        public string BUILDNUM { get; set; }
        #endregion
    }
}
