using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PainterWomen.Presentation.Controllers
{
    using Foundation;
    public class BlogController : BaseController
    using Foundation.Abstraction.Business;

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
