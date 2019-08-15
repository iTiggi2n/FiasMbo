using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.OperationStatus
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "OperationStatuses", IsNullable = true)]
    public class OperationStatuses
    {
        [XmlElement("OperationStatus")]
        public List<OperationStatus> OperationStatusList { get; set; } = new List<OperationStatus>();
    }
}
