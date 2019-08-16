using System;
using System.IO;
using NUnrar.Archive;

namespace FIAS.Archives.RarArchive
{
    class UnzippingRarFile : IUnzippingRarFile
    {
        public void UnzippingRarFileAndDelete(string pathFile, string fullPath)
        {
            try
            {
                using (Stream streamReader = new StreamReader(pathFile).BaseStream)
                {
                    NUnrar.Archive.RarArchive archive = NUnrar.Archive.RarArchive.Open(streamReader);
                    foreach (RarArchiveEntry entity in archive.Entries)
                    {
                        string path = Path.Combine(fullPath, entity.FilePath);
                        entity.WriteToFile(path);
                    }
                }
                File.Delete(pathFile);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
