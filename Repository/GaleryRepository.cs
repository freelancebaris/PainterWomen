using System.Collections.Generic;

using Foundation;
using Foundation.Abstraction.Repository;
using Foundation.Model.Galery;
using ServiceStack.OrmLite;

namespace Repository
{
    public class GaleryRepository : BaseRepository, IGaleryRepository
    {
        public List<PhotoGalery> GetAllPhotoGaleries()
        {
            List<PhotoGalery> imageGaleries;

            CreateTableIfNotExists<PhotoGalery>();

            using (var db = Connection.Open())
            {
                imageGaleries = db.Select<PhotoGalery>();
            }

            return imageGaleries;
        }
    }
}
