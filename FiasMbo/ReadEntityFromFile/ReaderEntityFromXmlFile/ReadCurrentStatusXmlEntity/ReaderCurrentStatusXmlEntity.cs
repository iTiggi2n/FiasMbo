using System.Xml;
using System.Xml.Serialization;
using FIAS.Entities.EntitiesFromXmlFile.CurrentStatus;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadCurrentStatusXmlEntity
{
    public class ReaderCurrentStatusXmlEntity : IReaderCurrentStatusXmlEntity
    {
        public void ReadCurrentStatusXmlEntity(XmlReader reader)
        {
            var dataTable = DataTableFromXmlEntity.DataTableFromXmlEntity.CreateDataTableFromEntity(new CurrentStatus());
            dataTable.TableName = "FIAS_ActualStatus";

            XmlSerializer serializer = new XmlSerializer(typeof(CurrentStatuses));
            CurrentStatuses currentStatuses = (CurrentStatuses)serializer.Deserialize(reader);

            foreach (var actualStatus in currentStatuses.CurrentStatusesList)
            {
                DataTableFromXmlEntity.DataTableFromXmlEntity.SetDataRow(dataTable, actualStatus);
            }
            //ToDo   экспорт в базу
            dataTable.Rows.Clear();
        }
    }
}
