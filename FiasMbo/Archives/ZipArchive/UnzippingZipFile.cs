using System;
using System.IO;
using System.IO.Compression;

namespace FIAS.Archives.ZipArchive
{
    class UnzippingZipFile : IUnzippingZipFile
    {
        public void UnzippingZipFileAndDelete(string pathFile, string fullPath)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(fullPath);
                foreach (FileInfo file in dirInfo.GetFiles())
                {
                    file.Delete();
                }
                ZipFile.ExtractToDirectory(pathFile, fullPath);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            File.Delete(pathFile);
        }
    }
}
