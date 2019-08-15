using Autofac;
using FIAS.Entities.EntitiesFromFiFile.AdditionalAddressInfo;
using FIAS.Log;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadAdditionalAddressInfoEntity
{
    public class ReaderAdditionalAddressInfoEntity : IReaderAdditionalAddressInfoEntity
    {
        public void ReadAdditionalAddressInfoEntity(XmlReader reader)
        {
            Builder.Buid().Resolve<ILoger>().Log($@"Start reading {reader.LocalName}");
            XmlSerializer serializer = new XmlSerializer(typeof(AdditionalAddressesInfo));
            AdditionalAddressesInfo additionalAddressesInfo = (AdditionalAddressesInfo)serializer.Deserialize(reader);
            var table = additionalAddressesInfo.CreateDataTable(additionalAddressesInfo.AdditionalAddressInfoList);
            Builder.Buid().Resolve<ILoger>().Log($@"Fin read {reader.LocalName}");
        }
    }
}
