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

    public class AdminAboutRepository :BaseRepository, IAdminAboutRepository
    {
        public About GetAbout()
        {
            List<About> about;
            using (var db = Connection.Open())
            {
                about = db.Select<About>();
            }

            return about.FirstOrDefault();
        }
    }
}
