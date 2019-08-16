using FIAS.Entities.EntitiesFromXmlFile.FlatType;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadFlatTypeXmlEntity
{
    public class ReaderFlatTypeXmlEntity : IReaderFlatTypeXmlEntity
    {
        public void ReadFlatTypeXmlEntity(XmlReader reader)
        {
            var dataTable = DataTableFromXmlEntity.DataTableFromXmlEntity.CreateDataTableFromEntity(new FlatType());
            dataTable.TableName = "FIAS_FlatType";

            XmlSerializer serializer = new XmlSerializer(typeof(FlatTypes));
            FlatTypes flatTypes = (FlatTypes)serializer.Deserialize(reader);

            foreach (var flatType in flatTypes.FlatTypeList)
            {
                DataTableFromXmlEntity.DataTableFromXmlEntity.SetDataRow(dataTable, flatType);
            }
            //ToDo   экспорт в базу
            dataTable.Rows.Clear();
        }
    }
}
