using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromFiFile.AddressObject
{
    [Serializable]
    [XmlRoot(Namespace = "http://www.v8.1c.ru/ssl/AddressSystem", ElementName = "AddressObjects", IsNullable = true)]

    public class AddressObjects : HeaderEntityFromFiFile
    {
        [XmlElement("Object")]
        public List<AddressObject> AddressObjectList { get; set; } = new List<AddressObject>();
    }
}
