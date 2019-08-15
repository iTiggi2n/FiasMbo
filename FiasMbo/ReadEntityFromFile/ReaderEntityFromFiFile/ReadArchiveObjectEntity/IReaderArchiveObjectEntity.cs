using System.Xml;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadArchiveObjectEntity
{
    public interface IReaderArchiveObjectEntity
    {
        void ReadArchiveObject(XmlReader reader);
    }
}
