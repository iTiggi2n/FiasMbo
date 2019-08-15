﻿using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIAS.WebRequests.WebPage
{
    interface IWebPage
    {
        HtmlDocument GetHtmlDocument(Uri uri, Encoding encoding);
    }
}
