using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.FlatType
{

    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "FlatType", IsNullable = true)]
    public class FlatType
    {
        [XmlAttribute("SHORTNAME")]
        public string SHORTNAME { get; set; }
        [XmlAttribute("NAME")]
        public string NAME { get; set; }
        [XmlAttribute("FLTYPEID")]
        public string FLTYPEID { get; set; }
    }
}
