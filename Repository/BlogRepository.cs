using System.Collections.Generic;
using System.Data;

using Foundation;
using Foundation.Abstraction.Repository;
using Foundation.Model.Blog;

using ServiceStack.OrmLite;


namespace Repository
{
    public class BlogRepository : IBlogRepository
    {
        public List<Blog> GetAllBlogByLang(string lang)
        {
            return null;
        }
    }
}
