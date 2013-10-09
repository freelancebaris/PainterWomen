using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Foundation.Business;

namespace PainterWomen.Presentation.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private readonly IDenemeBusiness _denemeBusiness;
        public HomeController(IDenemeBusiness denemeBusiness)
        {
            _denemeBusiness = denemeBusiness;
        }

        public ActionResult Index()
        {
            string deneme = _denemeBusiness.GetDenemeString();
            ViewBag.deneme = deneme;
            return View();
        }

        public ActionResult Index2()
        {
            return View();
        }

    }
}
