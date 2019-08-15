using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromFiFile.AddressStatus
{
    [Serializable]
    [XmlRoot(Namespace = "http://www.v8.1c.ru/ssl/AddressSystem", ElementName = "AddressStatuses", IsNullable = true)]
    public class AddressStatuses : HeaderEntityFromFiFile
    {
        [XmlElement("AddressStatus")]
        public List<AddressStatus> AddressStatusList { get; set; } = new List<AddressStatus>();
    }
}
