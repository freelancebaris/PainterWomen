using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using Foundation;
using Foundation.Abstraction.Services;
using Foundation.Model.SessionHelper;

namespace PainterWomen.Presentation.Controllers
{
    public class BaseController: Controller
    {
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (!filterContext.HttpContext.Request.IsAjaxRequest())
            {
                var sessionHelper = Core.Instance.Container.Resolve<ISessionHelper>();
                string langValue = "";
                if(filterContext.RequestContext.RouteData.Values["lang"] != null)
                {
                    langValue = filterContext.RequestContext.RouteData.Values["lang"].ToString();
                }

                ViewBag.Lang = Enums.Language.Tr.ToString();
                var userContext = new UserContext();
                userContext.SelectedLanguage = Enums.Language.Tr;
                if (!String.IsNullOrEmpty(langValue))
                {
                    var selectedLang = new Enums.Language();
                    var isParsed = Enum.TryParse(langValue, true, out selectedLang);
                    if (isParsed)
                    {
                        filterContext.Controller.ViewBag.Lang = langValue;
                        userContext.SelectedLanguage = selectedLang;
                        CultureInfo info = null;
                        switch (selectedLang)
                        {
                            case Enums.Language.Tr:
                                info = new CultureInfo("tr-TR");
                                break;
                            case Enums.Language.En:
                                info = new CultureInfo("en-GB");
                                break;
                        }
                        userContext.CultureInfo = info;
                        Thread.CurrentThread.CurrentCulture = info;
                        Thread.CurrentThread.CurrentUICulture = info;
                    }
                }
                sessionHelper.UserContext = userContext;
            }
            base.OnActionExecuting(filterContext);
        }
    }
}