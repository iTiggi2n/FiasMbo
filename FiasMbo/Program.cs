using Autofac;
using FIAS.ExtractDownloadFiles;
using FIAS.ExtractedFiles;
using FIAS.Model.DownloadRegions;
using FIAS.ReadEntityFromFile;
using System.Threading.Tasks;

namespace FIAS
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder.Buid().Resolve<IDownloadRegions>().SelectAndDownloadRegions();

            Builder.Buid().Resolve<IExtractDownloadFiles>().ExtractFiles();

            var filePaths = Builder.Buid().Resolve<IExtractedFiles>().SelectExtractedFiles();

            Parallel.ForEach(filePaths,
             path => Builder.Buid().Resolve<IReaderEntityFromFile>().ReadEntityFromFile(path));

        }
    }
}
