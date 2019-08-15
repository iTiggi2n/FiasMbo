using FIAS.Entities.EntitiesFromXmlFile.ActualStatus;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadActualStatusXmlEntity
{
    public class ReaderActualStatusXmlEntity : IReaderActualStatusXmlEntity
    {
        public void ReadActualStatusXmlEntity(XmlReader reader)
        {
            var dataTable = DataTableFromXmlEntity.DataTableFromXmlEntity.CreateDataTableFromEntity(new ActualStatus());
            dataTable.TableName = "FIAS_ActualStatus";

            XmlSerializer serializer = new XmlSerializer(typeof(ActualStatuses));
            ActualStatuses actualStatuses = (ActualStatuses)serializer.Deserialize(reader);

            foreach (var actualStatus in actualStatuses.ActualStatusList)
            {
                DataTableFromXmlEntity.DataTableFromXmlEntity.SetDataRow(dataTable, actualStatus);
            }
            //ToDo   экспорт в базу
            dataTable.Rows.Clear();
        }
    }
}
