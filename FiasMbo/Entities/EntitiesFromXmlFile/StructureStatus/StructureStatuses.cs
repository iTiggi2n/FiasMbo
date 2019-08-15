using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.StructureStatus
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "StructureStatuses", IsNullable = true)]
    public class StructureStatuses
    {
        [XmlElement("StructureStatus")]
        public List<StructureStatus> StructureStatusList { get; set; } = new List<StructureStatus>();
    }
}
