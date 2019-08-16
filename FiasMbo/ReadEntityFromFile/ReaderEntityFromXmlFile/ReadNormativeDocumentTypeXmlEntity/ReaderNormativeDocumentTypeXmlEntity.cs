using FIAS.Entities.EntitiesFromXmlFile.NormativeDocumentType;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadNormativeDocumentTypeXmlEntity
{
    public class ReaderNormativeDocumentTypeXmlEntity : IReaderNormativeDocumentTypeXmlEntity
    {
        public void ReadNormativeDocumentTypeXmlEntity(XmlReader reader)
        {
            var dataTable = DataTableFromXmlEntity.DataTableFromXmlEntity.CreateDataTableFromEntity(new NormativeDocumentType());
            dataTable.TableName = "FIAS_NormativeDocumentType";

            XmlSerializer serializer = new XmlSerializer(typeof(NormativeDocumentTypes));
            NormativeDocumentTypes normativeDocumentTypes = (NormativeDocumentTypes)serializer.Deserialize(reader);

            foreach (var normativeDocumentType in normativeDocumentTypes.NormativeDocumentTypeList)
            {
                DataTableFromXmlEntity.DataTableFromXmlEntity.SetDataRow(dataTable, normativeDocumentType);
            }
            //ToDo   экспорт в базу
            dataTable.Rows.Clear();
        }
    }
}
