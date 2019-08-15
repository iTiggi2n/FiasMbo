using Autofac;
using FIAS.WebRequests.WebPage;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAS.WebRequests.Fias
{
    class Fias : IFias
    {
        private const string FIAS_OFFICIAL_SITE = "https://fias.nalog.ru/Updates.aspx";
        private const string XPATH_FIAS_OFFICIAL_SITE = "//*[@id=\"ctl00_contentPlaceHolder_downloadGrid_ctl00__0\"]/td[3]/a";

        public Uri GetUriFiasFile()
        {

            HtmlDocument htmlDocument = Builder.Buid().Resolve<IWebPage>().GetHtmlDocument(new Uri(FIAS_OFFICIAL_SITE), Encoding.UTF8);

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

    }
}
