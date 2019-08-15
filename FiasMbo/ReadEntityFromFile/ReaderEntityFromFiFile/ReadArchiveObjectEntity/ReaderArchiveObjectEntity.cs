using Autofac;
using FIAS.Entities.EntitiesFromFiFile.ArchiveObject;
using FIAS.Log;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadArchiveObjectEntity
{
    public class ReaderArchiveObjectEntity : IReaderArchiveObjectEntity
    {
        public void ReadArchiveObject(XmlReader reader)
        {
            Builder.Buid().Resolve<ILoger>().Log($@"Start reading {reader.LocalName}");
            XmlSerializer serializer = new XmlSerializer(typeof(ArchiveObjects));
            ArchiveObjects archiveObjects = (ArchiveObjects)serializer.Deserialize(reader);
            var table = archiveObjects.CreateDataTable(archiveObjects.ArchiveObjectList);
            Builder.Buid().Resolve<ILoger>().Log($@"Fin read {reader.LocalName}");
        }
    }
}
