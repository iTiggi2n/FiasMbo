using System.Xml;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.RedSteadEntity
{
    public interface IReaderSteadEntity
    {
        void ReadSteadEntity(XmlReader reader);
    }
}
