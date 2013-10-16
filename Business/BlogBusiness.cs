using System.Collections.Generic;

using Foundation.Abstraction.Business;
using Foundation.Model.Blog;

namespace Business
{
    using Foundation.Abstraction.Repository;

    public class BlogBusiness : IBlogBusiness
    {
        private readonly IBlogRepository _blogRepository;

        public BlogBusiness(IBlogRepository blogRepository)
        {
            this._blogRepository = blogRepository;
        }

        public List<Blog> GetAllBlogByLang(string lang)
        {
            if (!string.IsNullOrEmpty(lang))
            {
                lang = lang.ToUpper();
            }
            return _blogRepository.GetAllBlogByLang(lang);
        }
    }
}
