using Autofac;
using FIAS.Archives;
using System.IO;

namespace FIAS.ExtractDownloadFiles
{
    public class ExtractDownloadFiles : IExtractDownloadFiles
    {
        public void ExtractFiles()
        {
            string downloadFilesPath = Path.Combine(Directory.GetCurrentDirectory(), DirectoryPaths.DOWNLOAD_FOLDER);
            var files = Directory.GetFiles(downloadFilesPath);
            foreach (var file in files)
            {
                Builder.Buid().Resolve<IUnzippingFile>().UnzipFile(file, Path.GetFileName(file));
            }
        }
    }
}
