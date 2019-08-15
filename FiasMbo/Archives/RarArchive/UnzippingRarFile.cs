using System;
using System.Collections.Generic;
using System.IO;
using NUnrar.Archive;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FIAS.Log;
using Autofac;

namespace FIAS.Archives.RarArchive
{
    class UnzippingRarFile : IUnzippingRarFile
    {
        public void UnzippingRarFileAndDelete(string pathFile, string fullPath)
        {
            try
            {
                Builder.Buid().Resolve<ILoger>().Log($@"Start UnzippingRarFile {pathFile}");
                using (Stream streamReader = new StreamReader(pathFile).BaseStream)
                {
                    NUnrar.Archive.RarArchive archive = NUnrar.Archive.RarArchive.Open(streamReader);
                    foreach (NUnrar.Archive.RarArchiveEntry entity in archive.Entries)
                    {
                        string path = Path.Combine(fullPath, entity.FilePath);
                        entity.WriteToFile(path);
                    }
                }
                Builder.Buid().Resolve<ILoger>().Log($@"End UnzippingRarFile {pathFile}");
                File.Delete(pathFile);
                Builder.Buid().Resolve<ILoger>().Log($@"File {pathFile} deleted");
            }
            catch (Exception ex)
            {
                Builder.Buid().Resolve<ILoger>().Log($@"Error UnzippingRarFile {pathFile}");
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
