using System.Web.Mvc;
using Foundation;
using Foundation.Abstraction.Business;

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
            var blogList = _blogBusiness.GetAllBlogByLang("tr");

            return View(blogList);
        }

    }
}
