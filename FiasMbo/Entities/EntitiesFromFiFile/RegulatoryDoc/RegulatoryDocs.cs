using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromFiFile.RegulatoryDoc
{
    [Serializable]
    [XmlRoot(Namespace = "http://www.v8.1c.ru/ssl/AddressSystem", ElementName = "RegulatoryDocs", IsNullable = true)]
    public class RegulatoryDocs : HeaderEntityFromFiFile
    {
        [XmlElement("RegulatoryDoc")]
        public List<RegulatoryDoc> RegulatoryDocList { get; set; } = new List<RegulatoryDoc>();
    }
}
