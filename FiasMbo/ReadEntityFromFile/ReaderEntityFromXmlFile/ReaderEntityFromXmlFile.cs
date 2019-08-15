using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadActualStatusXmlEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadAddressObjectXmlEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadCenterStatusXmlEntity;
using System.Xml;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile
{
    public class ReaderEntityFromXmlFile : IReaderEntityFromXmlFile
    {
        private IReaderActualStatusXmlEntity _readerActualStatusXmlEntity;
        private IReaderAddressObjectXmlEntity _readerAddressObjectXmlEntity;
        private IReaderCenterStatusXmlEntity _readerCenterStatusXmlEntity;
        public ReaderEntityFromXmlFile(IReaderActualStatusXmlEntity readerActualStatusXmlEntity,
            IReaderAddressObjectXmlEntity readerAddressObjectXmlEntity,
            IReaderCenterStatusXmlEntity readerCenterStatusXmlEntity)
        {
            _readerActualStatusXmlEntity = readerActualStatusXmlEntity;
            _readerAddressObjectXmlEntity = readerAddressObjectXmlEntity;
            _readerCenterStatusXmlEntity = readerCenterStatusXmlEntity;
        }
        public void ReadEntityFromXmlFile(string path)
        {
            XmlReader reader = XmlReader.Create(path);
            reader.MoveToContent();
            switch (reader.LocalName)
            {
                case "ActualStatuses":
                    {
                        _readerActualStatusXmlEntity.ReadActualStatusXmlEntity(reader);
                        break;
                    }
                case "AddressObjects":
                    {
                        _readerAddressObjectXmlEntity.ReadAddressObjectXmlEntity(reader);
                        break;
                    }
                case "CenterStatuses":
                    {
                        _readerCenterStatusXmlEntity.ReadCenterStatusXmlEntity(reader);
                        break;
                    }
            }
            //throw new NotImplementedException();
        }
    }
}
