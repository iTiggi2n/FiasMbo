using Autofac;
using FIAS.Log;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAS.Archives.ZipArchive
{
    class UnzippingZipFile : IUnzippingZipFile
    {
        public void UnzippingZipFileAndDelete(string pathFile, string fullPath)
        {

            try
            {
                Builder.Buid().Resolve<ILoger>().Log($@"Start UnzippingZipFile {pathFile}");

                DirectoryInfo dirInfo = new DirectoryInfo(fullPath);
                foreach (FileInfo file in dirInfo.GetFiles())
                {
                    file.Delete();
                }

                ZipFile.ExtractToDirectory(pathFile, fullPath);
            }
            catch (Exception ex)
            {
                Builder.Buid().Resolve<ILoger>().Log($@"Error UnzippingFile {pathFile}\r\n{ex.Message.ToString()}");
                throw new Exception(ex.Message.ToString());
            }
            Builder.Buid().Resolve<ILoger>().Log($@"End UnzippingZipFile {pathFile}");

            File.Delete(pathFile);

            Builder.Buid().Resolve<ILoger>().Log($@"Delete File {pathFile}");
        }
    }
}
