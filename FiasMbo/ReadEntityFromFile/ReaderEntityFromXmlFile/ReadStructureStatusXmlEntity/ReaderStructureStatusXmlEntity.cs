using FIAS.Entities.EntitiesFromXmlFile.StructureStatus;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadStructureStatusXmlEntity
{
    public class ReaderStructureStatusXmlEntity : IReaderStructureStatusXmlEntity
    {
        public void ReadStructureStatusXmlEntity(XmlReader reader)
        {
            var dataTable = DataTableFromXmlEntity.DataTableFromXmlEntity.CreateDataTableFromEntity(new StructureStatus());
            dataTable.TableName = "FIAS_ActualStatus";

            XmlSerializer serializer = new XmlSerializer(typeof(StructureStatuses));
            StructureStatuses structureStatuses = (StructureStatuses)serializer.Deserialize(reader);

            foreach (var structureStatus in structureStatuses.StructureStatusList)
            {
                DataTableFromXmlEntity.DataTableFromXmlEntity.SetDataRow(dataTable, structureStatus);
            }
            //ToDo   экспорт в базу
            dataTable.Rows.Clear();
        }
    }
}
