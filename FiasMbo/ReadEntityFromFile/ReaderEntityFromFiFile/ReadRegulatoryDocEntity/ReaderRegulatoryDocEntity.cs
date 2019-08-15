using Autofac;
using FIAS.Entities.EntitiesFromFiFile.RegulatoryDoc;
using FIAS.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadRegulatoryDocEntity
{
    public class ReaderRegulatoryDocEntity : IReaderRegulatoryDocEntity
    {
        public void ReadRegulatoryDocEntity(XmlReader reader)
        {
            Builder.Buid().Resolve<ILoger>().Log($@"Start reading {reader.LocalName}");
            XmlSerializer serializer = new XmlSerializer(typeof(RegulatoryDocs));
            RegulatoryDocs regulatoryDocs = (RegulatoryDocs)serializer.Deserialize(reader);
            var table = regulatoryDocs.CreateDataTable(regulatoryDocs.RegulatoryDocList);
            Builder.Buid().Resolve<ILoger>().Log($@"Fin read {reader.LocalName}");
        }
    }
}
