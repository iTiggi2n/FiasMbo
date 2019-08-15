using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromFiFile.ArchiveObject
{
    [Serializable]
    [XmlRoot(Namespace = "http://www.v8.1c.ru/ssl/AddressSystem", ElementName = "ArchiveObject", IsNullable = true)]
    public class ArchiveObject
    {
        [XmlAttribute("AOID")]
        public string AOID { get; set; }
        [XmlAttribute("AOGUID")]
        public string AOGUID { get; set; }
        [XmlAttribute("PARENTGUID")]
        public string PARENTGUID { get; set; }
        [XmlAttribute("PARENTGUIDMUN")]
        public string PARENTGUIDMUN { get; set; }
        [XmlAttribute("EXTRAGUID")]
        public string EXTRAGUID { get; set; }
        [XmlAttribute("AOLEVEL")]
        public string AOLEVEL { get; set; }
        [XmlAttribute("FORMALNAME")]
        public string FORMALNAME { get; set; }
        [XmlAttribute("SHORTNAME")]
        public string SHORTNAME { get; set; }
        [XmlAttribute("STARTDATE")]
        public string STARTDATE { get; set; }
        [XmlAttribute("ENDDATE")]
        public string ENDDATE { get; set; }
        [XmlAttribute("OPERSTATUS")]
        public string OPERSTATUS { get; set; }
    }
}
