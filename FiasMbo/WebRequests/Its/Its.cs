using Autofac;
using FIAS.WebRequests.WebPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FIAS.WebRequests.Its
{
    class Its : IIts
    {
        private const string ITS_1C = "https://its.1c.ru/download/fias2";

        public Dictionary<Uri, string> GetUriesFileIts1C(List<string> names)
        {
            if (names == null || !names.Any())
            {
                throw new Exception("Пустой список");
            }

            var htmlDocument = Builder.Buid().Resolve<IWebPage>().GetHtmlDocument(new Uri(ITS_1C), Encoding.GetEncoding("Windows-1251"));

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
    }
}
