using Autofac;
using FIAS.Entities.EntitiesFromFiFile.House;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadHouseEntity
{
    public class ReaderHouseEntity : IReaderHouseEntity
    {
        public void ReadHouseEntity(XmlReader reader)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Houses));
            Houses houses = (Houses)serializer.Deserialize(reader);
            var table = houses.CreateDataTable(houses.HouseList);
            //todo
        }
    }
}
