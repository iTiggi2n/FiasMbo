using FIAS.Entities.EntitiesFromXmlFile.IntervalStatus;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadIntervalStatusXmlEntity
{
    public class ReaderIntervalStatusXmlEntity : IReaderIntervalStatusXmlEntity
    {
        public void ReadIntervalStatusXmlEntity(XmlReader reader)
        {
            var dataTable = DataTableFromXmlEntity.DataTableFromXmlEntity.CreateDataTableFromEntity(new IntervalStatus());
            dataTable.TableName = "FIAS_IntervalStatus";

            XmlSerializer serializer = new XmlSerializer(typeof(IntervalStatuses));
            IntervalStatuses intervalStatuses = (IntervalStatuses)serializer.Deserialize(reader);

            foreach (var intervalStatus in intervalStatuses.IntervalStatusList)
            {
                DataTableFromXmlEntity.DataTableFromXmlEntity.SetDataRow(dataTable, intervalStatus);
            }
            //ToDo   экспорт в базу
            dataTable.Rows.Clear();
        }
    }
}
