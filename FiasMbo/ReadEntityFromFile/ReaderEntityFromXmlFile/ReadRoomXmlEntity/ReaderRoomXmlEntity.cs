using System.Xml;
using System.Xml.Serialization;
using FIAS.Entities.EntitiesFromXmlFile;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadRoomXmlEntity
{
    public class ReaderRoomXmlEntity : IReaderRoomXmlEntity
    {
        private const int MAX_EXPORT_COUNT_ROOM = 1000000;
        public void ReadRoomXmlEntity(XmlReader reader)
        {
            var dataTable = DataTableFromXmlEntity.DataTableFromXmlEntity.CreateDataTableFromEntity(new Room());
            dataTable.TableName = "FIAS_Room";

            while (reader.Read())
            {
                reader.ReadToFollowing("Room");
                XmlSerializer serializer = new XmlSerializer(typeof(Room));
                Room room = (Room)serializer.Deserialize(reader);
                if (room != null)
                {
                    DataTableFromXmlEntity.DataTableFromXmlEntity.SetDataRow(dataTable, room);
                }

                if (dataTable.Rows.Count == MAX_EXPORT_COUNT_ROOM)
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
