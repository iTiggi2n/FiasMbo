using Autofac;
using FIAS.Entities.EntitiesFromFiFile.ArchiveObject;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadArchiveObjectEntity
{
    public class ReaderArchiveObjectEntity : IReaderArchiveObjectEntity
    {
        public void ReadArchiveObject(XmlReader reader)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ArchiveObjects));
            ArchiveObjects archiveObjects = (ArchiveObjects)serializer.Deserialize(reader);
            var table = archiveObjects.CreateDataTable(archiveObjects.ArchiveObjectList);
        }
    }
}
