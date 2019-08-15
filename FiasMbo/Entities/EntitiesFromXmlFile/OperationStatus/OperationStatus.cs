using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.OperationStatus
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "OperationStatus", IsNullable = true)]
    public class OperationStatus
    {
        [XmlAttribute("NAME")]
        public string NAME { get; set; }
        [XmlAttribute("OPERSTATID")]
        public string OPERSTATID { get; set; }
    }
}
