using FIAS.Entities.EntitiesFromFiFile.AddressObject;
using FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadAdditionalAddressInfoEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadAddressObjectEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadAddressStatusEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadHouseEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadLinkEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.ReadRegulatoryDocEntity;
using FIAS.ReadEntityFromFile.ReaderEntityFromFiFile.RedSteadEntity;
using FiasOffSite.FI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace FIAS.ReadEntityFromFile.ReaderEntityFromFiFile
{
    public class ReaderEntityFromFiFile : IReaderEntityFromFiFile
    {
        private IReaderAddressObjectEntity _readerAddressObjectEntity;
        private IReaderAdditionalAddressInfoEntity _readerAdditionalAddressInfoEntity;
        private IReaderRegulatoryDocEntity _readerRegulatoryDocEntity;
        private IReaderHouseEntity _readerHouseEntity;
        private IReaderLinkEntity _readerLinkEntity;
        private IReaderSteadEntity _readerSteadEntity;
        private IReaderAddressStatusEnity _readerAddressStatusEnity;
        public ReaderEntityFromFiFile(IReaderAddressObjectEntity readerAddressObjectEntity,
            IReaderAdditionalAddressInfoEntity readerAdditionalAddressInfoEntity,
            IReaderRegulatoryDocEntity readerRegulatoryDocEntity,
            IReaderHouseEntity readerHouseEntity,
            IReaderLinkEntity readerLinkEntity,
            IReaderSteadEntity readerSteadEntity,
            IReaderAddressStatusEnity readerAddressStatusEnity)
        {
            _readerAddressObjectEntity = readerAddressObjectEntity;
            _readerAdditionalAddressInfoEntity = readerAdditionalAddressInfoEntity;
            _readerRegulatoryDocEntity = readerRegulatoryDocEntity;
            _readerHouseEntity = readerHouseEntity;
            _readerLinkEntity = readerLinkEntity;
            _readerSteadEntity = readerSteadEntity;
            _readerAddressStatusEnity = readerAddressStatusEnity;
        }
        public void ReadEntityFromFiFile(string path)
        {
            XmlReader reader = XmlReader.Create(new FIReader(path), null);
            reader.Read();
            switch (reader.LocalName)
            {
                case "AddressObjects":
                    {
                        _readerAddressObjectEntity.ReadAddressObjectEntity(reader);
                        break;
                    }
                case "AdditionalAddressInfo":
                    {
                        _readerAdditionalAddressInfoEntity.ReadAdditionalAddressInfoEntity(reader);
                        break;
                    }
                case "RegulatoryDocs":
                    {
                        _readerRegulatoryDocEntity.ReadRegulatoryDocEntity(reader);
                        break;
                    }
                case "Houses":
                    {
                        _readerHouseEntity.ReadHouseEntity(reader);
                        break;
                    }
                case "Links":
                    {
                        _readerLinkEntity.ReadLinkEntity(reader);
                        break;
                    }
                case "Steads":
                    {
                        _readerSteadEntity.ReadSteadEntity(reader);
                        break;
                    }
                case "AddressStatuses":
                    {
                        _readerAddressStatusEnity.ReadAddressStatusEnity(reader);
                        break;
                    }
                default:throw new Exception($"Error {reader.LocalName} not found");
            }
        }
    }
}
