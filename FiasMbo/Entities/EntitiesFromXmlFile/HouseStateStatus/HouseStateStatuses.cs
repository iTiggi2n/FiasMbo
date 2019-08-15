using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.HouseStateStatus
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "HouseStateStatuses", IsNullable = true)]
    public class HouseStateStatuses
    {
        [XmlElement("HouseStateStatus")]
        public List<HouseStateStatus> HouseStateStatusList { get; set; } = new List<HouseStateStatus>();
    }
}
