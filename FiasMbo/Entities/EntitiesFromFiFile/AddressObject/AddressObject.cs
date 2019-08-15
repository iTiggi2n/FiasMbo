using System;
using System.Data;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromFiFile.AddressObject
{
    [Serializable]
    [XmlRoot(Namespace = "http://www.v8.1c.ru/ssl/AddressSystem", ElementName = "Object", IsNullable = true)]
    public class AddressObject
    {
        [XmlAttribute("SHORTNAME")]
        public string ShortName { get; set; }
        [XmlAttribute("FORMALNAME")]
        public string FormalName { get; set; }
        [XmlAttribute("CODE")]
        public string Code { get; set; }
        [XmlAttribute("AOLEVEL")]
        public string AOLevel { get; set; }
        [XmlAttribute("EXTRAGUID")]
        public string ExtraGuid { get; set; }
        [XmlAttribute("PARENTGUIDMUN")]
        public string ParentGuidMum { get; set; }
        [XmlAttribute("PARENTGUID")]
        public string ParentGuid { get; set; }
        [XmlAttribute("AOGUID")]
        public string AOGuid { get; set; }
    }
}