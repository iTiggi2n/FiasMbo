using System.Linq;
using Autofac;
using FIAS.WebRequests.DownloadFile;
using FIAS.WebRequests.Fias;
using FIAS.WebRequests.Its;

namespace FIAS.Model.DownloadRegions
{
    public class DownloadRegions : IDownloadRegions
    {
        public void SelectAndDownloadRegions()
        {
            using (ModelContext modelContext = new ModelContext())
            {
                //если все регионы на обновлении, то скачиваем с офф сайта Fias 
                if (modelContext.Regions.Where(o => o.IsUpdate == false).Count() == 0)
                {
                    var uri = Builder.Buid().Resolve<IFias>().GetUriFiasFile();
                    Builder.Buid().Resolve<IDownloadFile>().Download(uri, uri.Segments.LastOrDefault());
                }
                else
                {
                    //если часть регионов на обновлении, то скачиваем с сайта Its
                    var regions = modelContext.Regions.Where(o => o.IsUpdate == true).Select(o => o.RegionName).ToList<string>();
                    var uries = Builder.Buid().Resolve<IIts>().GetUriesFileIts1C(regions);
                    foreach (var uri in uries)
                    {
                        Builder.Buid().Resolve<IDownloadFile>().Download(uri.Key, uri.Value + ".zip");
                    }
                }
            }
        }
    }
}
