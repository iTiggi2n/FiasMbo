using FIAS.Entities.EntitiesFromFiFile.RegulatoryDoc;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadRegulatoryDocEntity
{
    public class ReaderRegulatoryDocEntity : IReaderRegulatoryDocEntity
    {
        public void ReadRegulatoryDocEntity(XmlReader reader)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(RegulatoryDocs));
            RegulatoryDocs regulatoryDocs = (RegulatoryDocs)serializer.Deserialize(reader);
            var table = regulatoryDocs.CreateDataTable(regulatoryDocs.RegulatoryDocList);
        }
    }
}
