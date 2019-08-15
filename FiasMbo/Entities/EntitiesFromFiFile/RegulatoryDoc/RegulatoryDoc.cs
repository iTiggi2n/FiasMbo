using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromFiFile.RegulatoryDoc
{
    [Serializable]
    [XmlRoot(Namespace = "http://www.v8.1c.ru/ssl/AddressSystem", ElementName = "RegulatoryDoc", IsNullable = true)]
    public class RegulatoryDoc
    {
        [XmlAttribute("DESCRISDESCR")]
        public string DESCRISDESCR { get; set; }
        [XmlAttribute("OBJID")]
        public string OBJID { get; set; }
        [XmlAttribute("DOCID")]
        public string DOCID { get; set; }
        [XmlAttribute("REGIONCODE")]
        public string REGIONCODE { get; set; }
    }
}
