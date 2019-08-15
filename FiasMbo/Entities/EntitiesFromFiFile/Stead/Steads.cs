using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromFiFile.Stead
{
    [Serializable]
    [XmlRoot(Namespace = "http://www.v8.1c.ru/ssl/AddressSystem", ElementName = "Steads", IsNullable = true)]
    public class Steads : HeaderEntityFromFiFile
    {
        [XmlElement("Stead")]
        public List<Stead> SteadList { get; set; } = new List<Stead>();
    }
}
