using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.RoomType
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "RoomTypes", IsNullable = true)]
    public class RoomTypes
    {
        [XmlElement("RoomType")]
        public List<RoomType> RoomTypeList { get; set; } = new List<RoomType>();
    }
}
