using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.AddressObjectType
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "AddressObjectTypes", IsNullable = true)]
    public class AddressObjectTypes
    {
        [XmlElement("AddressObjectType")]
        public List<AddressObjectType> AddressObjectTypeList { get; set; } = new List<AddressObjectType>();
    }
}
