using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation;
using Foundation.Abstraction.Repository;
using Foundation.Model.Gallery;
using ServiceStack.OrmLite;

namespace Repository
{
    public class GalleryRepository:BaseRepository, IGalleryRepository
    {
        public List<Album> GetAlbums(Enums.Language lang)
        {
            var albums = new List<Album>();
            var langId = (int) lang;
            using (var db = Connection.Open())
            {
                 albums = db.Select<Album>(album => album.Lang == langId).ToList();
            }
            return albums;

        }
    }
}
