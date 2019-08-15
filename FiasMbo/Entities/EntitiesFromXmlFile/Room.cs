using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile
{

    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "Room", IsNullable = true)]
    public class Room
    {
        #region properties
        [XmlAttribute("OPERSTATUS")]
        public string OPERSTATUS { get; set; }
        [XmlAttribute("ENDDATE")]
        public string ENDDATE { get; set; }
        [XmlAttribute("STARTDATE")]
        public string STARTDATE { get; set; }
        [XmlAttribute("NORMDOC")]
        public string NORMDOC { get; set; }
        [XmlAttribute("UPDATEDATE")]
        public string UPDATEDATE { get; set; }
        [XmlAttribute("LIVESTATUS")]
        public string LIVESTATUS { get; set; }
        [XmlAttribute("REGIONCODE")]
        public string REGIONCODE { get; set; }
        [XmlAttribute("NEXTID")]
        public string NEXTID { get; set; }
        [XmlAttribute("POSTALCODE")]
        public string POSTALCODE { get; set; }
        [XmlAttribute("ROOMCADNUM")]
        public string ROOMCADNUM { get; set; }
        [XmlAttribute("ROOMTYPE")]
        public string ROOMTYPE { get; set; }
        [XmlAttribute("ROOMNUMBER")]
        public string ROOMNUMBER { get; set; }
        [XmlAttribute("FLATTYPE")]
        public string FLATTYPE { get; set; }
        [XmlAttribute("FLATNUMBER")]
        public string FLATNUMBER { get; set; }
        [XmlAttribute("HOUSEGUID")]
        public string HOUSEGUID { get; set; }
        [XmlAttribute("ROOMGUID")]
        public string ROOMGUID { get; set; }
        [XmlAttribute("ROOMID")]
        public string ROOMID { get; set; } 
        #endregion
    }
}
