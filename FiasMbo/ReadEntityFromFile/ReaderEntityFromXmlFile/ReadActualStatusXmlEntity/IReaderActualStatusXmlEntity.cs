using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadActualStatusXmlEntity
{
    public interface IReaderActualStatusXmlEntity
    {
        void ReadActualStatusXmlEntity(XmlReader reader);
    }
}
