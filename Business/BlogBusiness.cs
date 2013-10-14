using System.Collections.Generic;

using Foundation.Abstraction.Business;
using Foundation.Model.Blog;

namespace Business
{

    public class BlogBusiness : IBlogBusiness
    {
        private readonly IBlogBusiness _blogRepository;

        public BlogBusiness(IBlogBusiness blogRepository)
        {
            this._blogRepository = blogRepository;
        }

        public List<Blog> GetAllBlogByLang(Foundation.Enums.Language language)
        {
            return _blogRepository.GetAllBlogByLang(language);
        }
    }
}
