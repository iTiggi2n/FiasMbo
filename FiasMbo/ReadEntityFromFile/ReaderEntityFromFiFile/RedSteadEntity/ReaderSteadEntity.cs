using Autofac;
using FIAS.Entities.EntitiesFromFiFile.Stead;
using FIAS.Log;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.RedSteadEntity
{
    class ReaderSteadEntity : IReaderSteadEntity
    {
        public void ReadSteadEntity(XmlReader reader)
        {
            Builder.Buid().Resolve<ILoger>().Log($@"Start reading {reader.LocalName}");
            XmlSerializer serializer = new XmlSerializer(typeof(Steads));
            Steads steads = (Steads)serializer.Deserialize(reader);
            var table = steads.CreateDataTable(steads.SteadList);
            Builder.Buid().Resolve<ILoger>().Log($@"Fin read {reader.LocalName}");
        }
    }
}
