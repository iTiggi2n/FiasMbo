using Autofac;
using FIAS.Entities.EntitiesFromFiFile.AddressObject;
using FIAS.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadAddressObjectEntity
{
    class ReaderAddressObjectEntity : IReaderAddressObjectEntity
    {
        public void ReadAddressObjectEntity(XmlReader reader)
        {
            Builder.Buid().Resolve<ILoger>().Log($@"Start reading {reader.LocalName}");
            XmlSerializer serializer = new XmlSerializer(typeof(AddressObjects));
            AddressObjects addressObjects = (AddressObjects)serializer.Deserialize(reader);
            var table = addressObjects.CreateDataTable(addressObjects.AddressObjectList);
            Builder.Buid().Resolve<ILoger>().Log($@"Fin read {reader.LocalName}");
            /*ToDo
            *bulk BulkSynchronize
            * */
        }
    }
}
