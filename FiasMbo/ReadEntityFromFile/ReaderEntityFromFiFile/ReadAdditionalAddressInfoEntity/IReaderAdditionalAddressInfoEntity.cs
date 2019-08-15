using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadAdditionalAddressInfoEntity
{
    public interface IReaderAdditionalAddressInfoEntity
    {
        void ReadAdditionalAddressInfoEntity(XmlReader reader);
    }
}
