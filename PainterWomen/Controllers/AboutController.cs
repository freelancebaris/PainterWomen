using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PainterWomen.Presentation.Controllers
{
    using Foundation.Abstraction.Business;

    public class AboutController : BaseController
    {
        private readonly IAboutBusiness _aboutBusiness;

        public AboutController(IAboutBusiness aboutBusiness)
        {
            this._aboutBusiness = aboutBusiness;
        }

        public ActionResult Index()
        {
            var about = _aboutBusiness.GetAboutByLang("tr");

            return View(about);
        }

    }
}
