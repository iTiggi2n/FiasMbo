using System.Xml;
using System.Xml.Serialization;
using FIAS.Entities.EntitiesFromXmlFile;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadHouseXmlEntity
{
    public class ReaderHouseXmlEntity : IReaderHouseXmlEntity
    {
        private const int MAX_EXPORT_COUNT_HOUSES = 1000000;
        public void ReadHouseXmlEntity(XmlReader reader)
        {
            var dataTable = DataTableFromXmlEntity.DataTableFromXmlEntity.CreateDataTableFromEntity(new House());
            dataTable.TableName = "FIAS_Houses";

            while (reader.Read())
            {
                reader.ReadToFollowing("House");
                XmlSerializer serializer = new XmlSerializer(typeof(House));
                House house = (House)serializer.Deserialize(reader);
                if (house != null)
                {
                    DataTableFromXmlEntity.DataTableFromXmlEntity.SetDataRow(dataTable, house);
                }

                if (dataTable.Rows.Count == MAX_EXPORT_COUNT_HOUSES)
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
