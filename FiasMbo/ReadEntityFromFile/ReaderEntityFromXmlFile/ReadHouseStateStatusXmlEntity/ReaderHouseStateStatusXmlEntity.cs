using FIAS.Entities.EntitiesFromXmlFile.HouseStateStatus;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadHouseStateStatusXmlEntity
{
    public class ReaderHouseStateStatusXmlEntity : IReaderHouseStateStatusXmlEntity
    {
        public void ReadHouseStateStatusXmlEntity(XmlReader reader)
        {
            var dataTable = DataTableFromXmlEntity.DataTableFromXmlEntity.CreateDataTableFromEntity(new HouseStateStatus());
            dataTable.TableName = "FIAS_HouseStateStatus";

            XmlSerializer serializer = new XmlSerializer(typeof(HouseStateStatuses));
            HouseStateStatuses houseStateStatuses = (HouseStateStatuses)serializer.Deserialize(reader);

            foreach (var houseStateStatus in houseStateStatuses.HouseStateStatusList)
            {
                DataTableFromXmlEntity.DataTableFromXmlEntity.SetDataRow(dataTable, houseStateStatus);
            }
            //ToDo   экспорт в базу
            dataTable.Rows.Clear();
        }
    }
}
