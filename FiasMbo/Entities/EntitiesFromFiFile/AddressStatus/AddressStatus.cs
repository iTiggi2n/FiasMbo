using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromFiFile.AddressStatus
{
    [Serializable]
    [XmlRoot(Namespace = "http://www.v8.1c.ru/ssl/AddressSystem", ElementName = "AddressStatus", IsNullable = true)]
    public class AddressStatus
    {
        [XmlAttribute("VALUE")]
        public string VALUE { get; set; }
        [XmlAttribute("ID")]
        public string ID { get; set; }
        [XmlAttribute("TYPE")]
        public string TYPE { get; set; }
        [XmlAttribute("KEY")]
        public string KEY { get; set; }
    }
}
