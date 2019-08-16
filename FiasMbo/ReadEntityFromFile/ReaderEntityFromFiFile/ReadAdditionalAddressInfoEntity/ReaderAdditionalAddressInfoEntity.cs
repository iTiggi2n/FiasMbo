using Autofac;
using FIAS.Entities.EntitiesFromFiFile.AdditionalAddressInfo;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadAdditionalAddressInfoEntity
{
    public class ReaderAdditionalAddressInfoEntity : IReaderAdditionalAddressInfoEntity
    {
        public void ReadAdditionalAddressInfoEntity(XmlReader reader)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(AdditionalAddressesInfo));
            AdditionalAddressesInfo additionalAddressesInfo = (AdditionalAddressesInfo)serializer.Deserialize(reader);
            if (additionalAddressesInfo != null)
            {
                var table = additionalAddressesInfo.CreateDataTable(additionalAddressesInfo.AdditionalAddressInfoList);
            }
        }
    }
}
