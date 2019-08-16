using System.Xml;
using System.Xml.Serialization;
using FIAS.Entities.EntitiesFromXmlFile;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadNormativeDocumentXmlEntity
{
    public class ReaderNormativeDocumentXmlEntity : IReaderNormativeDocumentXmlEntity
    {
        private const int MAX_EXPORT_COUNT_NORMANIVE_DOCUMENT= 1000000;
        public void ReadNormativeDocumentXmlEntity(XmlReader reader)
        {
            var dataTable = DataTableFromXmlEntity.DataTableFromXmlEntity.CreateDataTableFromEntity(new NormativeDocument());
            dataTable.TableName = "FIAS_NormativeDocument";

            while (reader.Read())
            {
                reader.ReadToFollowing("NormativeDocument");
                XmlSerializer serializer = new XmlSerializer(typeof(NormativeDocument));
                NormativeDocument normativeDocument = (NormativeDocument)serializer.Deserialize(reader);
                if (normativeDocument != null)
                {
                    DataTableFromXmlEntity.DataTableFromXmlEntity.SetDataRow(dataTable, normativeDocument);
                }

                if (dataTable.Rows.Count == MAX_EXPORT_COUNT_NORMANIVE_DOCUMENT)
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
