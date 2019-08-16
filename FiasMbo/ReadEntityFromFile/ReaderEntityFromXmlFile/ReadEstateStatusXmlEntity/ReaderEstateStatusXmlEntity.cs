using FIAS.Entities.EntitiesFromXmlFile.EstateStatus;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadEstateStatusXmlEntity
{
    public class ReaderEstateStatusXmlEntity : IReaderEstateStatusXmlEntity
    {
        public void ReadEstateStatusXmlEntity(XmlReader reader)
        {
            var dataTable = DataTableFromXmlEntity.DataTableFromXmlEntity.CreateDataTableFromEntity(new EstateStatus());
            dataTable.TableName = "FIAS_EstateStatus";

            XmlSerializer serializer = new XmlSerializer(typeof(EstateStatuses));
            EstateStatuses estateStatuses = (EstateStatuses)serializer.Deserialize(reader);

            foreach (var estateStatus in estateStatuses.EstateStatusList)
            {
                DataTableFromXmlEntity.DataTableFromXmlEntity.SetDataRow(dataTable, estateStatus);
            }
            //ToDo   экспорт в базу
            dataTable.Rows.Clear();
        }
    }
}
