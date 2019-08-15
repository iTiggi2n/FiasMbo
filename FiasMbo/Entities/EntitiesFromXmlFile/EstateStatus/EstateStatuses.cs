using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.EstateStatus
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "EstateStatuses", IsNullable = true)]
    public class EstateStatuses
    {
        [XmlElement("EstateStatus")]
        public List<EstateStatus> EstateStatusList { get; set; } = new List<EstateStatus>();
    }
}
