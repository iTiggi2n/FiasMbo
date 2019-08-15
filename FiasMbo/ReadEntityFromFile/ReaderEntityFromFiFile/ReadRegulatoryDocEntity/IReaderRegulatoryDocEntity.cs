using System.Xml;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadRegulatoryDocEntity
{
    public interface IReaderRegulatoryDocEntity
    {
        void ReadRegulatoryDocEntity(XmlReader reader);
    }
}
