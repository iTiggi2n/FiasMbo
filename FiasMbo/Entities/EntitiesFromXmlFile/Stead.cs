using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "Stead", IsNullable = true)]
    public class Stead
    {
        #region properties
        [XmlAttribute("OPERSTATUS")]
        public string OPERSTATUS { get; set; }
        [XmlAttribute("ENDDATE")]
        public string ENDDATE { get; set; }
        [XmlAttribute("STARTDATE")]
        public string STARTDATE { get; set; }
        [XmlAttribute("PARENTGUID")]
        public string PARENTGUID { get; set; }
        [XmlAttribute("DIVTYPE")]
        public string DIVTYPE { get; set; }
        [XmlAttribute("NORMDOC")]
        public string NORMDOC { get; set; }
        [XmlAttribute("UPDATEDATE")]
        public string UPDATEDATE { get; set; }
        [XmlAttribute("OKTMO")]
        public string OKTMO { get; set; }
        [XmlAttribute("OKATO")]
        public string OKATO { get; set; }
        [XmlAttribute("IFNSUL")]
        public string IFNSUL { get; set; }
        [XmlAttribute("IFNSFL")]
        public string IFNSFL { get; set; }
        [XmlAttribute("LIVESTATUS")]
        public string LIVESTATUS { get; set; }
        [XmlAttribute("REGIONCODE")]
        public string REGIONCODE { get; set; }
        [XmlAttribute("POSTALCODE")]
        public string POSTALCODE { get; set; }
        [XmlAttribute("TERRIFNSUL")]
        public string TERRIFNSUL { get; set; }
        [XmlAttribute("TERRIFNSFL")]
        public string TERRIFNSFL { get; set; }
        [XmlAttribute("STEADID")]
        public string STEADID { get; set; }
        [XmlAttribute("NUMBER")]
        public string NUMBER { get; set; }
        [XmlAttribute("STEADGUID")]
        public string STEADGUID { get; set; }
        #endregion
    }
}
