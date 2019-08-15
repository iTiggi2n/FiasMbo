using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.RoomType
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "RoomType", IsNullable = true)]
    public class RoomType
    {
        [XmlAttribute("NAME")]
        public string NAME { get; set; }
        [XmlAttribute("SHORTNAME")]
        public string SHORTNAME { get; set; }
        [XmlAttribute("RMTYPEID")]
        public string RMTYPEID { get; set; }
    }
}
