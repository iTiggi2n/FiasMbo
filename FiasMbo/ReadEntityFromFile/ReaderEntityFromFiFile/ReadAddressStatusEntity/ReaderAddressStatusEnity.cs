using Autofac;
using FIAS.Entities.EntitiesFromFiFile.AddressStatus;
using FIAS.Log;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadAddressStatusEntity
{
    public class ReaderAddressStatusEnity : IReaderAddressStatusEnity
    {
        public void ReadAddressStatusEnity(XmlReader reader)
        {
            Builder.Buid().Resolve<ILoger>().Log($@"Start reading {reader.LocalName}");
            XmlSerializer serializer = new XmlSerializer(typeof(AddressStatuses));
            AddressStatuses addressStatuses = (AddressStatuses)serializer.Deserialize(reader);
            var table = addressStatuses.CreateDataTable(addressStatuses.AddressStatusList);
            Builder.Buid().Resolve<ILoger>().Log($@"Fin read {reader.LocalName}");
        }
    }
}
