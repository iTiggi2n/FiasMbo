using FIAS.Entities.EntitiesFromFiFile.AddressObject;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadAddressObjectEntity
{
    class ReaderAddressObjectEntity : IReaderAddressObjectEntity
    {
        public void ReadAddressObjectEntity(XmlReader reader)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(AddressObjects));
            AddressObjects addressObjects = (AddressObjects)serializer.Deserialize(reader);
            var table = addressObjects.CreateDataTable(addressObjects.AddressObjectList);
            /*ToDo
            *bulk BulkSynchronize
            * */
        }
    }
}
