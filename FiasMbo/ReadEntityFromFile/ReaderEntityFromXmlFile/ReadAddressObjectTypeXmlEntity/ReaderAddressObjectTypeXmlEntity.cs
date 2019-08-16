using FIAS.Entities.EntitiesFromXmlFile.AddressObjectType;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadAddressObjectTypeXmlEntity
{
    public class ReaderAddressObjectTypeXmlEntity : IReaderAddressObjectTypeXmlEntity
    {
        public void ReadAddressObjectTypeXmlEntity(XmlReader reader)
        {
            var dataTable = DataTableFromXmlEntity.DataTableFromXmlEntity.CreateDataTableFromEntity(new AddressObjectType());
            dataTable.TableName = "FIAS_AddressObjectType";

            XmlSerializer serializer = new XmlSerializer(typeof(AddressObjectTypes));
            AddressObjectTypes addressObjectTypes = (AddressObjectTypes)serializer.Deserialize(reader);

            foreach (var addressObjectType in addressObjectTypes.AddressObjectTypeList)
            {
                DataTableFromXmlEntity.DataTableFromXmlEntity.SetDataRow(dataTable, addressObjectType);
            }
            //ToDo   экспорт в базу
            dataTable.Rows.Clear();
        }
    }
}
