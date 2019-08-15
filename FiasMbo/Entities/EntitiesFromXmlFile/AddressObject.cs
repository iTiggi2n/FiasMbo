using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "Object", IsNullable = true)]
    public class AddressObject
    {
        #region properties
        [XmlAttribute("AOID")]
        public string AOID { get; set; }
        [XmlAttribute("AOGUID")]
        public string AOGUID { get; set; }
        [XmlAttribute("PARENTGUID")]
        public string PARENTGUID { get; set; }
        [XmlAttribute("NEXTID")]
        public string NEXTID { get; set; }
        [XmlAttribute("FORMALNAME")]
        public string FORMALNAME { get; set; }
        [XmlAttribute("OFFNAME")]
        public string OFFNAME { get; set; }
        [XmlAttribute("SHORTNAME")]
        public string SHORTNAME { get; set; }
        [XmlAttribute("AOLEVEL")]
        public string AOLEVEL { get; set; }
        [XmlAttribute("REGIONCODE")]
        public string REGIONCODE { get; set; }
        [XmlAttribute("AREACODE")]
        public string AREACODE { get; set; }
        [XmlAttribute("AUTOCODE")]
        public string AUTOCODE { get; set; }
        [XmlAttribute("CITYCODE")]
        public string CITYCODE { get; set; }
        [XmlAttribute("CTARCODE")]
        public string CTARCODE { get; set; }
        [XmlAttribute("PLACECODE")]
        public string PLACECODE { get; set; }
        [XmlAttribute("PLANCODE")]
        public string PLANCODE { get; set; }
        [XmlAttribute("STREETCODE")]
        public string STREETCODE { get; set; }
        [XmlAttribute("EXTRCODE")]
        public string EXTRCODE { get; set; }
        [XmlAttribute("SEXTCODE")]
        public string SEXTCODE { get; set; }
        [XmlAttribute("PLAINCODE")]
        public string PLAINCODE { get; set; }
        [XmlAttribute("CURRSTATUS")]
        public string CURRSTATUS { get; set; }
        [XmlAttribute("ACTSTATUS")]
        public string ACTSTATUS { get; set; }
        [XmlAttribute("LIVESTATUS")]
        public string LIVESTATUS { get; set; }
        [XmlAttribute("CENTSTATUS")]
        public string CENTSTATUS { get; set; }
        [XmlAttribute("OPERSTATUS")]
        public string OPERSTATUS { get; set; }
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
        [XmlAttribute("DIVTYPE")]
        public string DIVTYPE { get; set; }

        #endregion
    }
}
