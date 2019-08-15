using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.CurrentStatus
{

    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "CurrentStatuses", IsNullable = true)]
    public class CurrentStatuses
    {
        [XmlElement("CurrentStatus")]
        public List<CurrentStatus> CurrentStatusesList { get; set; } = new List<CurrentStatus>();
    }
}
