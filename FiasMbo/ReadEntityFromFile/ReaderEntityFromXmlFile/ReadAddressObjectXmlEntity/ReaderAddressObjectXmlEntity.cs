using System;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadAddressObjectXmlEntity
{
    public class ReaderAddressObjectXmlEntity : IReaderAddressObjectXmlEntity
    {
        const int MAX_EXPORT_COUNT_ADDRESS_OBJECTS = 10000;
        public void ReadAddressObjectXmlEntity(XmlReader reader)
        {
            var dataTable = DataTableFromXmlEntity.DataTableFromXmlEntity.CreateDataTableFromEntity(new Entities.EntitiesFromXmlFile.AddressObject());
            dataTable.TableName = "FIAS_AddressObject";

            while (reader.Read())
            {
                reader.ReadToFollowing("Object");
                XmlSerializer serializer = new XmlSerializer(typeof(Entities.EntitiesFromXmlFile.AddressObject));
                Entities.EntitiesFromXmlFile.AddressObject addressObject = (Entities.EntitiesFromXmlFile.AddressObject)serializer.Deserialize(reader);
                if (addressObject != null)
                {
                    DataTableFromXmlEntity.DataTableFromXmlEntity.SetDataRow(dataTable, addressObject);
                }

                if (dataTable.Rows.Count == MAX_EXPORT_COUNT_ADDRESS_OBJECTS)
                {
                    //ToDo   экспорт в базу
                    dataTable.Rows.Clear();
                }
            }

            //ToDo   экспорт в базу
            dataTable.Rows.Clear();
        }
    }
}
