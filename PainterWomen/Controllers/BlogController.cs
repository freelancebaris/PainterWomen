using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Foundation.Abstraction.Business;
using Foundation;

namespace PainterWomen.Presentation.Controllers
{
    public class BlogController : BaseController
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
