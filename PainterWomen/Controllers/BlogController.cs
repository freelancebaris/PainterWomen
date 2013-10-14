using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PainterWomen.Presentation.Controllers
{
    using Foundation;
    using Foundation.Abstraction.Business;

    public class BlogController : Controller
    {
        private readonly IBlogBusiness _blogBusiness;

        public BlogController(IBlogBusiness blogBusiness)
        {
            _blogBusiness = blogBusiness;
        }

        public ActionResult Index()
        {
            var blogList = _blogBusiness.GetAllBlogByLang(Enums.Language.Tr);

            return View(blogList);
        }

    }
}
