using System;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.NormativeDocumentType
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "NormativeDocumentType", IsNullable = true)]
    public class NormativeDocumentType
    {
        [XmlAttribute("NAME")]
        public string NAME { get; set; }
        [XmlAttribute("NDTYPEID")]
        public string NDTYPEID { get; set; }
    }
}
