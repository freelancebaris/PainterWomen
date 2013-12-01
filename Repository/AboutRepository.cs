using Foundation;
using Foundation.Abstraction.Repository;
using Foundation.Model.About;

using ServiceStack.OrmLite;

namespace Repository
{
    using System.Collections.Generic;

    public class AboutRepository : BaseRepository, IAboutRepository
    {
        public About GetAboutByLang(string lang)
        {
            About about;
            CreateTableIfNotExists<About>();
            using (var db = Connection.Open())
            {
                about = db.FirstOrDefault<About>(a => a.Lang == lang);
            }

            return about;
        }


        public List<AboutImageGalery> GetAboutImageGaleries()
        {
            var imageGaleries = new List<AboutImageGalery>();
            CreateTableIfNotExists<AboutImageGalery>();

            using (var db = Connection.Open())
            {
                imageGaleries = db.Select<AboutImageGalery>();
            }

            return imageGaleries;
        }
    }
}
