using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.IntervalStatus
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "IntervalStatuses", IsNullable = true)]
    public class IntervalStatuses
    {
        [XmlElement("IntervalStatus")]
        public List<IntervalStatus> IntervalStatusList { get; set; } = new List<IntervalStatus>();
    }
}
