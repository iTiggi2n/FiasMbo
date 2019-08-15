using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromFiFile.ArchiveObject
{
    [Serializable]
    [XmlRoot(Namespace = "http://www.v8.1c.ru/ssl/AddressSystem", ElementName = "ArchiveObjects", IsNullable = true)]

    public class ArchiveObjects : HeaderEntityFromFiFile
    {
        [XmlElement("ArchiveObject")]
        public List<ArchiveObject> ArchiveObjectList { get; set; } = new List<ArchiveObject>();
    }
}