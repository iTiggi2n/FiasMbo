using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadHouseEntity
{
    public interface IReaderHouseEntity
    {
        void ReadHouseEntity(XmlReader reader);
    }
}
