using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PainterWomen.Presentation.Controllers
{
    using Foundation.Abstraction.Business;

    public class GaleryController : BaseController
    {
        private readonly IGaleryBusiness _galeryBusiness;

        public GaleryController(IGaleryBusiness galeryBusiness)
        {
            this._galeryBusiness = galeryBusiness;
        }

        public ActionResult Index()
        {
            var viewModel = _galeryBusiness.GaleryViewModel();

            return View(viewModel);
        }

    }
}
