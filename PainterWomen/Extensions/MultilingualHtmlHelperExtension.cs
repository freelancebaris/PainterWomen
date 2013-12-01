using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Foundation;

namespace PainterWomen.Presentation.Extensions
{
    public static class MultilingualHtmlHelperExtension
    {
        public static string GetMLValue(this HtmlHelper htmlHelper,  string key)
        {
            return Core.Instance.Multilingual.GetValue(key, "");
        }
    }
}