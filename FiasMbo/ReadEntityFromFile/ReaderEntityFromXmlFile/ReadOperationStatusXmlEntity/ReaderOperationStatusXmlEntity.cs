using FIAS.Entities.EntitiesFromXmlFile.OperationStatus;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadOperationStatusXmlEntity
{
    public class ReaderOperationStatusXmlEntity : IReaderOperationStatusXmlEntity
    {
        public void ReadOperationStatusXmlEntity(XmlReader reader)
        {
            var dataTable = DataTableFromXmlEntity.DataTableFromXmlEntity.CreateDataTableFromEntity(new OperationStatus());
            dataTable.TableName = "FIAS_OperationStatus";

            XmlSerializer serializer = new XmlSerializer(typeof(OperationStatuses));
            OperationStatuses operationStatuses = (OperationStatuses)serializer.Deserialize(reader);

            foreach (var operationStatus in operationStatuses.OperationStatusList)
            {
                DataTableFromXmlEntity.DataTableFromXmlEntity.SetDataRow(dataTable, operationStatus);
            }
            //ToDo   экспорт в базу
            dataTable.Rows.Clear();
        }
    }
}
