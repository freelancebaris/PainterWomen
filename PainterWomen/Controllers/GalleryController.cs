using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Foundation.Abstraction.Business;
using Foundation.Model.Gallery;

namespace PainterWomen.Presentation.Controllers
{
    public class GalleryController : BaseController
    {
        private readonly IGalleryBusiness _business;
        public GalleryController(IGalleryBusiness business)
        {
            _business = business;
        }

        public ActionResult Index()
        {
            ViewBag.MenuIndex = 3;
            return View();
        }

        public JsonResult GetAlbums()
        {
            List<Album> albums = _business.GetAlbums();

            return Json(new {success = true, albums = albums});
        }

        public ActionResult Detail()
        {
            ViewBag.MenuIndex = 3;
            return View();
        }

    }
}
