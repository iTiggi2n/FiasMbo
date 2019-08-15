using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromFiFile.House
{
    [Serializable]
    [XmlRoot(Namespace = "http://www.v8.1c.ru/ssl/AddressSystem", ElementName = "Houses", IsNullable = true)]
    public class Houses : HeaderEntityFromFiFile
    {
        [XmlElement("House")]
        public List<House> HouseList { get; set; } = new List<House>();
    }
}
