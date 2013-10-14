using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PainterWomen.Presentation.Controllers
{
    public class GalleryController : BaseController
    {
        public ActionResult Index()
        {
            ViewBag.MenuIndex = 3;
            return View();
        }

    }
}
