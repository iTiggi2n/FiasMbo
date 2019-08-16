using FIAS.Entities.EntitiesFromXmlFile.RoomType;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadRoomTypeXmlEntity
{
    public class ReaderRoomTypeXmlEntity : IReaderRoomTypeXmlEntity
    {
        public void ReadRoomTypeXmlEntity(XmlReader reader)
        {
            var dataTable = DataTableFromXmlEntity.DataTableFromXmlEntity.CreateDataTableFromEntity(new RoomType());
            dataTable.TableName = "FIAS_RoomType";

            XmlSerializer serializer = new XmlSerializer(typeof(RoomTypes));
            RoomTypes roomTypes = (RoomTypes)serializer.Deserialize(reader);

            foreach (var roomType in roomTypes.RoomTypeList)
            {
                DataTableFromXmlEntity.DataTableFromXmlEntity.SetDataRow(dataTable, roomType);
            }
            //ToDo   экспорт в базу
            dataTable.Rows.Clear();
        }
    }
}
