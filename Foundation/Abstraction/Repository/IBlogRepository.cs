using System.Collections.Generic;
using Foundation.Model.Blog;

namespace Foundation.Abstraction.Repository
{
    public interface IBlogRepository
    {
        List<Blog> GetAllBlogByLang(string lang);
    }
}
