using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadActualStatusXmlEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadAddressObjectTypeXmlEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadAddressObjectXmlEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadCenterStatusXmlEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadCurrentStatusXmlEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadEstateStatusXmlEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadFlatTypeXmlEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadHouseStateStatusXmlEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadHouseXmlEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadIntervalStatusXmlEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadNormativeDocumentTypeXmlEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadNormativeDocumentXmlEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadOperationStatusXmlEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadRoomTypeXmlEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadRoomXmlEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadSteadXmlEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile.ReadStructureStatusXmlEntity;
using System;
using System.Xml;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile
{
    public class ReaderEntityFromXmlFile : IReaderEntityFromXmlFile
    {
        private IReaderActualStatusXmlEntity _readerActualStatusXmlEntity;
        private IReaderAddressObjectXmlEntity _readerAddressObjectXmlEntity;
        private IReaderAddressObjectTypeXmlEntity _readerAddressObjectTypeXmlEntity;
        private IReaderCenterStatusXmlEntity _readerCenterStatusXmlEntity;
        private IReaderCurrentStatusXmlEntity _readerCurrentStatusXmlEntity;
        private IReaderEstateStatusXmlEntity _readerEstateStatusXmlEntity;
        private IReaderFlatTypeXmlEntity _readerFlatTypeXmlEntity;
        private IReaderHouseStateStatusXmlEntity _readerHouseStateStatusXmlEntity;
        private IReaderHouseXmlEntity _readerHouseXmlEntity;
        private IReaderIntervalStatusXmlEntity _readerIntervalStatusXmlEntity;
        private IReaderNormativeDocumentTypeXmlEntity _readerNormativeDocumentTypeXmlEntity;
        private IReaderNormativeDocumentXmlEntity _readerNormativeDocumentXmlEntity;
        private IReaderOperationStatusXmlEntity _readerOperationStatusXmlEntity;
        private IReaderRoomTypeXmlEntity _readerRoomTypeXmlEntity;
        private IReaderRoomXmlEntity _readerRoomXmlEntity;
        private IReaderSteadXmlEntity _readerSteadXmlEntity;
        private IReaderStructureStatusXmlEntity _readerStructureStatusXmlEntity;

        public ReaderEntityFromXmlFile(IReaderActualStatusXmlEntity readerActualStatusXmlEntity,
            IReaderAddressObjectXmlEntity readerAddressObjectXmlEntity,
            IReaderCenterStatusXmlEntity readerCenterStatusXmlEntity,
            IReaderCurrentStatusXmlEntity readerCurrentStatusXmlEntity,
            IReaderHouseXmlEntity readerHouseXmlEntity,
            IReaderRoomXmlEntity readerRoomXmlEntity,
            IReaderEstateStatusXmlEntity readerEstateStatusXmlEntity,
            IReaderFlatTypeXmlEntity readerFlatTypeXmlEntity,
            IReaderHouseStateStatusXmlEntity readerHouseStateStatusXmlEntity,
            IReaderIntervalStatusXmlEntity readerIntervalStatusXmlEntity,
            IReaderNormativeDocumentTypeXmlEntity readerNormativeDocumentTypeXmlEntity,
            IReaderNormativeDocumentXmlEntity readerNormativeDocumentXmlEntity,
            IReaderOperationStatusXmlEntity readerOperationStatusXmlEntity,
            IReaderRoomTypeXmlEntity readerRoomTypeXmlEntity,
            IReaderSteadXmlEntity readerSteadXmlEntity,
            IReaderStructureStatusXmlEntity readerStructureStatusXmlEntity,
            IReaderAddressObjectTypeXmlEntity readerAddressObjectTypeXmlEntity)
        {
            _readerActualStatusXmlEntity = readerActualStatusXmlEntity;
            _readerAddressObjectXmlEntity = readerAddressObjectXmlEntity;
            _readerCenterStatusXmlEntity = readerCenterStatusXmlEntity;
            _readerCurrentStatusXmlEntity = readerCurrentStatusXmlEntity;
            _readerHouseXmlEntity = readerHouseXmlEntity;
            _readerRoomXmlEntity = readerRoomXmlEntity;
            _readerEstateStatusXmlEntity = readerEstateStatusXmlEntity;
            _readerFlatTypeXmlEntity = readerFlatTypeXmlEntity;
            _readerHouseStateStatusXmlEntity = readerHouseStateStatusXmlEntity;
            _readerIntervalStatusXmlEntity = readerIntervalStatusXmlEntity;
            _readerNormativeDocumentTypeXmlEntity = readerNormativeDocumentTypeXmlEntity;
            _readerNormativeDocumentXmlEntity = readerNormativeDocumentXmlEntity;
            _readerOperationStatusXmlEntity = readerOperationStatusXmlEntity;
            _readerRoomTypeXmlEntity = readerRoomTypeXmlEntity;
            _readerSteadXmlEntity = readerSteadXmlEntity;
            _readerStructureStatusXmlEntity = readerStructureStatusXmlEntity;
            _readerAddressObjectTypeXmlEntity = readerAddressObjectTypeXmlEntity;
        }
        public void ReadEntityFromXmlFile(string path)
        {
            XmlReader reader = XmlReader.Create(path);
            reader.MoveToContent();
            Console.WriteLine(reader.LocalName);
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
                case "CurrentStatuses":
                    {
                        _readerCurrentStatusXmlEntity.ReadCurrentStatusXmlEntity(reader);
                        break;
                    }
                case "Houses":
                    {
                        _readerHouseXmlEntity.ReadHouseXmlEntity(reader);
                        break;
                    }
                case "Rooms":
                    {
                        _readerRoomXmlEntity.ReadRoomXmlEntity(reader);
                        break;
                    }
                case "EstateStatuses":
                    {
                        _readerEstateStatusXmlEntity.ReadEstateStatusXmlEntity(reader);
                        break;
                    }
                case "FlatTypes":
                    {
                        _readerFlatTypeXmlEntity.ReadFlatTypeXmlEntity(reader);
                        break;
                    }
                case "HouseStateStatuses":
                    {
                        _readerHouseStateStatusXmlEntity.ReadHouseStateStatusXmlEntity(reader);
                        break;
                    }
                case "IntervalStatuses":
                    {
                        _readerIntervalStatusXmlEntity.ReadIntervalStatusXmlEntity(reader);
                        break;
                    }
                case "NormativeDocumentTypes":
                    {
                        _readerNormativeDocumentTypeXmlEntity.ReadNormativeDocumentTypeXmlEntity(reader);
                        break;
                    }
                case "NormativeDocumentes":
                    {
                        _readerNormativeDocumentXmlEntity.ReadNormativeDocumentXmlEntity(reader);
                        break;
                    }
                case "OperationStatuses":
                    {
                        _readerOperationStatusXmlEntity.ReadOperationStatusXmlEntity(reader);
                        break;
                    }
                case "RoomTypes":
                    {
                        _readerRoomTypeXmlEntity.ReadRoomTypeXmlEntity(reader);
                        break;
                    }
                case "Steads":
                    {
                        _readerSteadXmlEntity.ReadSteadXmlEntity(reader);
                        break;
                    }
                case "StructureStatuses":
                    {
                        _readerStructureStatusXmlEntity.ReadStructureStatusXmlEntity(reader);
                        break;
                    }
                case "AddressObjectTypes":
                    {
                        _readerAddressObjectTypeXmlEntity.ReadAddressObjectTypeXmlEntity(reader);
                        break;
                    }
                default: throw new System.Exception($"not fount entity {reader.LocalName}");
            }
        }
    }
}
