using System.Collections.Generic;

using Foundation;
using Foundation.Abstraction.Repository;
using Foundation.Model.Galery;
using ServiceStack.OrmLite;

namespace Repository
{
    public class GaleryRepository : DataContext, IGaleryRepository
    {
        public List<PhotoGalery> GetAllPhotoGaleries()
        {
            List<PhotoGalery> imageGaleries;

            CreateTableIfNotExists<PhotoGalery>();

            OrmLiteConfig.DialectProvider = DefaultProvider;
            var dbFactory = new OrmLiteConnectionFactory(SqliteFileDb, DefaultProvider);

            using (var db = dbFactory.Open())
            {
                imageGaleries = db.Select<PhotoGalery>();
            }

            return imageGaleries;
        }
    }
}
