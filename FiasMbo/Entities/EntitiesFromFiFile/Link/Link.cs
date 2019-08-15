using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromFiFile.Link
{
    [Serializable]
    [XmlRoot(Namespace = "http://www.v8.1c.ru/ssl/AddressSystem", ElementName = "Link", IsNullable = true)]
    public class Link
    {
        [XmlAttribute("AOGUID")]
        public string AOGUID { get; set; }
        [XmlAttribute("MUNPARENTGUID")]
        public string MUNPARENTGUID { get; set; }
    }
}
