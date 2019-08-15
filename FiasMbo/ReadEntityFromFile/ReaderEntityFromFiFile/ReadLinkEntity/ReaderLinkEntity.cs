using Autofac;
using FIAS.Entities.EntitiesFromFiFile.Link;
using FIAS.Log;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadLinkEntity
{
    public class ReaderLinkEntity : IReaderLinkEntity
    {
        public void ReadLinkEntity(XmlReader reader)
        {
            Builder.Buid().Resolve<ILoger>().Log($@"Start reading {reader.LocalName}");
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(reader);
            XmlSerializer serializer = new XmlSerializer(typeof(Links));
            using (TextReader sr = new StringReader(xmlDocument.InnerXml))
            {
                Links links = (Links)serializer.Deserialize(sr);
                var table = links.CreateDataTable(links.LinkList);
                Builder.Buid().Resolve<ILoger>().Log($@"Fin read {reader.LocalName}");
                //todo
            }
        }
    }
}
