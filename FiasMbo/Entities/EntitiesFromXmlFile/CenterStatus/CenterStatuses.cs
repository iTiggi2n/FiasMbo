using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.CenterStatus
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "CenterStatuses", IsNullable = true)]
    public class CenterStatuses
    {
        [XmlElement("CenterStatus")]
        public List<CenterStatus> CentralStatusList { get; set; } = new List<CenterStatus>();
    }
}
