using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FIAS.WebRequests
{
    public class ParsePage
    {
        private const string FIAS_OFFICIAL_SITE = "https://fias.nalog.ru/Updates.aspx";
        private const string XPATH_FIAS_OFFICIAL_SITE = "//*[@id=\"ctl00_contentPlaceHolder_downloadGrid_ctl00__0\"]/td[3]/a";
        private const string ITS_1C = "https://its.1c.ru/download/fias2";
        public static Uri GetUriRarFileFIAS()
        {
            HtmlDocument htmlDocument = GetHtmlDocument(new Uri(FIAS_OFFICIAL_SITE), Encoding.UTF8);

            var node = htmlDocument.DocumentNode.SelectSingleNode(XPATH_FIAS_OFFICIAL_SITE);

            if (node == null)
            {
                throw new Exception("Не найден узел по xPath по ссылке " + FIAS_OFFICIAL_SITE);
            }

            HtmlAttribute attr = node.Attributes.FirstOrDefault();

            if (attr == null)
            {
                throw new Exception("Не найдена ссылка по xPath");
            }

            return new Uri(attr.Value);
        }
        public static Dictionary<Uri, string> GetUriesZipFileIts1C(List<string> names)
        {
            if (names == null && !names.Any())
            {
                throw new Exception("Пустой список");
            }
            var htmlDocument = GetHtmlDocument(new Uri(ITS_1C), Encoding.GetEncoding("Windows-1251"));
            var nodes = htmlDocument.DocumentNode.SelectNodes("//a[@class='fias download2']");
            if (nodes == null)
            {
                throw new Exception("Не найден строки по xPath по ссылке " + ITS_1C);
            }

            Dictionary<Uri, string> ret = new Dictionary<Uri, string>();
            Uri uriIts1C = new Uri(ITS_1C);

            string domain = uriIts1C.AbsoluteUri.Replace(uriIts1C.AbsolutePath, "");

            foreach (var node in nodes)
            {
                if (names.Contains(node.InnerText))
                {
                    ret.Add(new Uri(domain + node.Attributes.FirstOrDefault().Value), node.InnerText);
                }
            }
            return ret;
        }

        public static HtmlDocument GetHtmlDocument(Uri uri, Encoding encoding)
        {
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

                return htmlDocument;
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка при получения страницы:\r\n" + ex.Message.ToString());
            }
        }
        public static void DownloadFileFromLink(Uri uri, string path, string fileName)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile(uri, Path.Combine(path, fileName)); //название и можно путь провести, если папки не существует то ее надо создать заране
        }
    }
}
