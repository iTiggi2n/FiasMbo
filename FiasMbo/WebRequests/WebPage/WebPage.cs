using System;
using System.IO;
using System.Net;
using System.Text;
using HtmlAgilityPack;

namespace FIAS.WebRequests.WebPage
{
    class WebPage : IWebPage
    {
        public HtmlDocument GetHtmlDocument(Uri uri, Encoding encoding)
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
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
