using FIAS.Entities.EntitiesFromFiFile.Stead;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.RedSteadEntity
{
    class ReaderSteadEntity : IReaderSteadEntity
    {
        public void ReadSteadEntity(XmlReader reader)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Steads));
            Steads steads = (Steads)serializer.Deserialize(reader);
            var table = steads.CreateDataTable(steads.SteadList);
        }
    }
}
