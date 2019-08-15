using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromFiFile.Link
{
    [Serializable]
    [XmlRoot(Namespace = "http://www.v8.1c.ru/ssl/AddressSystem", ElementName = "Links", IsNullable = true)]
    public class Links : HeaderEntityFromFiFile
    {
        [XmlElement("Links")]
        public List<Link> LinkList { get; set; } = new List<Link>();
    }
}
