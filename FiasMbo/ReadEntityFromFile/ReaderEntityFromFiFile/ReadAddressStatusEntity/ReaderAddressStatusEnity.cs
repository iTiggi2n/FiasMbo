using FIAS.Entities.EntitiesFromFiFile.AddressStatus;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadAddressStatusEntity
{
    public class ReaderAddressStatusEnity : IReaderAddressStatusEnity
    {
        public void ReadAddressStatusEnity(XmlReader reader)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AddressStatuses));
            AddressStatuses addressStatuses = (AddressStatuses)serializer.Deserialize(reader);
            var table = addressStatuses.CreateDataTable(addressStatuses.AddressStatusList);
        }
    }
}
