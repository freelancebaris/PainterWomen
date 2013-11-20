using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.AdminKP
{
    using Foundation.Abstraction.Repository.AdminKP;
    using Foundation.Model.About;

    using ServiceStack.OrmLite;

    public class AdminAboutRepository :DataContext, IAdminAboutRepository
    {
        public About GetAbout()
        {
            List<About> about;

            OrmLiteConfig.DialectProvider = DefaultProvider;
            var dbFactory = new OrmLiteConnectionFactory(SqliteFileDb, DefaultProvider);

            using (var db = dbFactory.Open())
            {
                about = db.Select<About>();
            }

            return about.FirstOrDefault();
        }
    }
}
