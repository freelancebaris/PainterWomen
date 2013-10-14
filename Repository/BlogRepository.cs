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
           var blogs = new List<Blog>();
            CreateTableIfNotExists<Blog>();

            OrmLiteConfig.DialectProvider = DefaultProvider;
            var dbFactory = new OrmLiteConnectionFactory(SqliteFileDb, DefaultProvider);

            using (var db = dbFactory.Open())
            {
                var blogList = db.Where<Blog>(new { Lang = lang });

                foreach (Blog blog in blogList)
                {
                    blogs.Add(blog);
                }
            }

            return blogs;
        }
    }
}
