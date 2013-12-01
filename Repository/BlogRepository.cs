using System.Collections.Generic;
using System.Data;

using Foundation;
using Foundation.Abstraction.Repository;
using Foundation.Model.Blog;

using ServiceStack.OrmLite;


namespace Repository
{
    public class BlogRepository :BaseRepository, IBlogRepository
    {
        public List<Blog> GetAllBlogByLang(string lang)
        {
           var blogs = new List<Blog>();
            CreateTableIfNotExists<Blog>();

            using (var db = Connection.Open())
            {
                var blogList = db.Where<Blog>(new { Lang = lang });
                blogs.AddRange(blogList);
            }

            return blogs;
        }
    }
}
