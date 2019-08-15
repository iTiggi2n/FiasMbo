using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.ActualStatus
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "ActualStatuses", IsNullable = true)]

    public class CenterStatuses
    {
        [XmlElement("ActualStatus")]
        public List<ActualStatus> ActualStatusList { get; set; } = new List<ActualStatus>();
    }
}
