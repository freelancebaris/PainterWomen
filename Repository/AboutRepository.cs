using Foundation;
using Foundation.Abstraction.Repository;
using Foundation.Model.About;

using ServiceStack.OrmLite;

namespace Repository
{
    public class AboutRepository : DataContext, IAboutRepository
    {
        public About GetAboutByLang(string lang)
        {
            About about;
            CreateTableIfNotExists<About>();

            OrmLiteConfig.DialectProvider = DefaultProvider;
            var dbFactory = new OrmLiteConnectionFactory(SqliteFileDb, DefaultProvider);

            using (var db = dbFactory.Open())
            {
                about = db.FirstOrDefault<About>(a => a.Lang == lang);
            }

            return about;
        }
    }
}
