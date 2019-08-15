using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FIAS.Entities.EntitiesFromFiFile.AdditionalAddressInfo
{

    [Serializable]
    [XmlRoot(Namespace = "http://www.v8.1c.ru/ssl/AddressSystem", ElementName = "AdditionalAddressInfo", IsNullable = true)]

    public class AdditionalAddressesInfo : HeaderEntityFromFiFile
    {
        [XmlElement("AdditionalAddressInfo")]
        public List<AdditionalAddressInfo> AdditionalAddressInfoList { get; set; } = new List<AdditionalAddressInfo>();
    }
}
