using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Foundation;
using Foundation.Abstraction.Services;

namespace PainterWomen.Presentation.Controllers
{
    public class PublicController: BaseController
    {
        private readonly ISessionHelper _sessionHelper;
        public PublicController(ISessionHelper sessionHelper)
        {
            _sessionHelper = sessionHelper;
        }

        //public JsonResult GetMenuLinks()
        //{

        //    if (_sessionHelper.UserContext.SelectedLanguage == Enums.Language.Tr)
        //    {
                
        //    }
        //}
    }
}
