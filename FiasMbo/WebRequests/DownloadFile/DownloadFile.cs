using System;
using System.IO;
using System.Net;
using Autofac;
using FIAS.Log;

namespace FIAS.WebRequests.DownloadFile
{
    public sealed class DownloadFile : IDownloadFile
    {
        const int TRY_COUNT_DOWNLOAD_FILE = 5;
        public void Download(Uri uri, string fileName)
        {
            Builder.Buid().Resolve<ILoger>().Log($@"Начинает загружатся файл по ссылке {uri}");
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
                    webClient.DownloadFile(uri, Path.Combine(DirectoryPaths.DOWNLOAD_FOLDER, fileName.Replace(@"/","")));
                    Builder.Buid().Resolve<ILoger>().Log($@"Загружен файл по ссылке {uri}");

                    result = true;
                }
                catch (Exception ex)
                {
                    Builder.Buid().Resolve<ILoger>().Log($@"Ошибка при загрузке файла по ссылке {uri}\r\n Попытка номер - {currentTry}\r\n {ex.Message.ToString()}");
                }
            }
        }
    }
}
