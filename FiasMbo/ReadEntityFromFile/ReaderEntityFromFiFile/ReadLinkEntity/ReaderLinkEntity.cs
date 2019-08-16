using FIAS.Entities.EntitiesFromFiFile.Link;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadLinkEntity
{
    public class ReaderLinkEntity : IReaderLinkEntity
    {
        public void ReadLinkEntity(XmlReader reader)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(reader);
            XmlSerializer serializer = new XmlSerializer(typeof(Links));
            using (TextReader sr = new StringReader(xmlDocument.InnerXml))
            {
                Links links = (Links)serializer.Deserialize(sr);
                var table = links.CreateDataTable(links.LinkList);
                //todo
            }
        }
    }
}
