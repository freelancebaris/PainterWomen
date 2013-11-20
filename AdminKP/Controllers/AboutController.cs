using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdminKP.Controllers
{
    using Foundation.Abstraction.Business.AdminKP;

    public class AboutController : Controller
    {
        private readonly IAdminAboutBusiness _adminAboutBusiness;

        public AboutController(IAdminAboutBusiness adminAboutBusiness)
        {
            this._adminAboutBusiness = adminAboutBusiness;
        }

        public ActionResult Index()
        {
            return View();
        }


        public JsonResult GetAbout()
        {
            try
            {
                var about = _adminAboutBusiness.GetAbout();
                return Json(new { Result = "OK", Records = about }, JsonRequestBehavior.AllowGet);
            }

            catch (Exception ex)
            {
                return Json(new { Result = "ERROR", Message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}
