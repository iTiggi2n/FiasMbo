using FIAS.Entities.EntitiesFromXmlFile;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadSteadXmlEntity
{
    public class ReaderSteadXmlEntity : IReaderSteadXmlEntity
    {
        private const int MAX_EXPORT_COUNT_STEAD = 10000000;
        public void ReadSteadXmlEntity(XmlReader reader)
        {
            var dataTable = DataTableFromXmlEntity.DataTableFromXmlEntity.CreateDataTableFromEntity(new Stead());
            dataTable.TableName = "FIAS_Stead";

            while (reader.Read())
            {
                reader.ReadToFollowing("Room");
                XmlSerializer serializer = new XmlSerializer(typeof(Stead));
                Stead stead = (Stead)serializer.Deserialize(reader);
                if (stead != null)
                {
                    DataTableFromXmlEntity.DataTableFromXmlEntity.SetDataRow(dataTable, stead);
                }

                if (dataTable.Rows.Count == MAX_EXPORT_COUNT_STEAD)
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
