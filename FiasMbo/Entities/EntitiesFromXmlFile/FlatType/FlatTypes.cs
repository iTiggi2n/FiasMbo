using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromXmlFile.FlatType
{
    [Serializable]
    [XmlRoot(Namespace = "", ElementName = "FlatTypes", IsNullable = true)]
    public class FlatTypes
    {
        [XmlElement("FlatType")]
        public List<FlatType> FlatTypeList { get; set; } = new List<FlatType>();
    }
}
