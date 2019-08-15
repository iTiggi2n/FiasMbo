using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using FIAS.Log;
using HtmlAgilityPack;

namespace FIAS.WebRequests.WebPage
{
    class WebPage : IWebPage
    {
        public HtmlDocument GetHtmlDocument(Uri uri, Encoding encoding)
        {
            Builder.Buid().Resolve<ILoger>().Log($@"Начинает загружатся страница по ссылке {uri}");
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                request.Method = "GET";
                string webResponse = string.Empty;

                using (StreamReader streamReader = new StreamReader(request.GetResponse().GetResponseStream(), Encoding.GetEncoding("Windows-1251")))
                {
                    webResponse = streamReader.ReadToEnd();
                }

                HtmlDocument htmlDocument = new HtmlDocument();
                htmlDocument.LoadHtml(webResponse);

                Builder.Buid().Resolve<ILoger>().Log($@"Страница по ссылке {uri} загружена");
                return htmlDocument;
            }
            catch (Exception ex)
            {
                Builder.Buid().Resolve<ILoger>().Log($@"Ошибка при загрузке страницы по ссылке {uri} \r\n {ex.Message.ToString()}");
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
