using System.Collections.Generic;
using Foundation.Model.Blog;

namespace Foundation.Abstraction.Business
{
    public interface IBlogBusiness
    {
        List<Blog> GetAllBlogByLang(string language);
    }
}
