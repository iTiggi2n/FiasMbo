using System;
using System.IO;
using System.Net;

namespace FIAS.WebRequests.DownloadFile
{
    public sealed class DownloadFile : IDownloadFile
    {
        const int TRY_COUNT_DOWNLOAD_FILE = 5;
        public void Download(Uri uri, string fileName)
        {
            bool result = false;
            int currentTry = 0;
            while (!result && currentTry < TRY_COUNT_DOWNLOAD_FILE)
            {
                currentTry++;
                try
                {
                    WebClient webClient = new WebClient();
                    if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(), DirectoryPaths.DOWNLOAD_FOLDER)))
                    {
                        Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), DirectoryPaths.DOWNLOAD_FOLDER));
                    }
                    webClient.DownloadFile(uri, Path.Combine(DirectoryPaths.DOWNLOAD_FOLDER, fileName.Replace(@"/", "")));

                    result = true;
                }
                catch (Exception) { }
            }
        }
    }
}
