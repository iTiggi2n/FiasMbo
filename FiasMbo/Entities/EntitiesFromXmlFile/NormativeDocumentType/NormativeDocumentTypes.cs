using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.NormativeDocumentType
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "NormativeDocumentTypes", IsNullable = true)]
    public class NormativeDocumentTypes
    {
        [XmlElement("NormativeDocumentType")]
        public List<NormativeDocumentType> NormativeDocumentTypeList { get; set; } = new List<NormativeDocumentType>();
    }
}
