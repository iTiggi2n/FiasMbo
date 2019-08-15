using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAS.WebRequests.DownloadFile
{
    public interface IDownloadFile
    {
        void Download(Uri uri, string fileName);
    }
}
