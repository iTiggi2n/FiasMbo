using System.Xml;
using System.Xml.Serialization;
using FIAS.Entities.EntitiesFromXmlFile.CenterStatus;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadCenterStatusXmlEntity
{
    public class ReaderCenterStatusXmlEntity : IReaderCenterStatusXmlEntity
    {
        public void ReadCenterStatusXmlEntity(XmlReader reader)
        {
            var dataTable = DataTableFromXmlEntity.DataTableFromXmlEntity.CreateDataTableFromEntity(new CenterStatus());
            dataTable.TableName = "FIAS_CenterStatus";

            XmlSerializer serializer = new XmlSerializer(typeof(CenterStatuses));
            CenterStatuses centerStatuses = (CenterStatuses)serializer.Deserialize(reader);

            foreach (var centralStatus in centerStatuses.CentralStatusList)
            {
                DataTableFromXmlEntity.DataTableFromXmlEntity.SetDataRow(dataTable, centralStatus);
            }
            //ToDo   экспорт в базу
            dataTable.Rows.Clear();
        }
    }
}
