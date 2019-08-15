using FIAS.ReadEntityFromFile.ReaderEntityFromFiFile;
using FIAS.ReadEntityFromFile.ReaderEntityFromXmlFile;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAS.ReadEntityFromFile
{
    class ReaderEntityFromFile : IReaderEntityFromFile
    {
        private IReaderEntityFromXmlFile _readerEntityFromXmlFile;
        private IReaderEntityFromFiFile _readerEntityFromFiFile;
        public ReaderEntityFromFile(IReaderEntityFromXmlFile readerEntityFromXmlFile,
            IReaderEntityFromFiFile readerEntityFromFiFile)
        {
            _readerEntityFromXmlFile = readerEntityFromXmlFile;
            _readerEntityFromFiFile = readerEntityFromFiFile;
        }
        public void ReadEntityFromFile(string path)
        {
            switch (Path.GetExtension(path).ToLower())
            {
                case FileExtension.FI:
                    {
                        _readerEntityFromFiFile.ReadEntityFromFiFile(path);
                        break;
                    }
                case FileExtension.XML:
                    {
                        _readerEntityFromXmlFile.ReadEntityFromXmlFile(path);
                        break;
                    }
                default: throw new Exception("Неверный формат файла");
            }
        }
    }
}
