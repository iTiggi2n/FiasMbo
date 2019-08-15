using FIAS.Archives.RarArchive;
using FIAS.Archives.ZipArchive;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAS.Archives
{
    class UnzippingFile : IUnzippingFile
    {
        private IUnzippingRarFile _unzippingRarFile;
        private IUnzippingZipFile _unzippingZipFile;

        const string RAR_EXTENSION = ".rar";
        const string ZIP_EXTENSION = ".zip";
        
        public UnzippingFile(IUnzippingRarFile unzippingRarFile, IUnzippingZipFile unzippingZipFile)
        {
            _unzippingRarFile = unzippingRarFile;
            _unzippingZipFile = unzippingZipFile;
        }

        public void UnzipFile(string pathFile, string unzippingFolderName)
        {
            if (!File.Exists(pathFile))
            {
                throw new Exception("Файл не найден");
            }

            string fullPath = Path.Combine(Directory.GetCurrentDirectory(), DirectoryPaths.FILE_FOLDER, unzippingFolderName);
            if (!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(fullPath);
            }
            FileInfo fileInfo = new FileInfo(pathFile);

            switch (fileInfo.Extension)
            {
                case RAR_EXTENSION:
                    {
                        _unzippingRarFile.UnzippingRarFileAndDelete(pathFile, fullPath);
                        break;
                    }
                case ZIP_EXTENSION:
                    {
                        _unzippingZipFile.UnzippingZipFileAndDelete(pathFile, fullPath);
                        break;
                    }
                default: throw new Exception("Неверное расширение файла");
            }
        }
    }
}
