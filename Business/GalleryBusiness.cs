using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation.Abstraction.Business;
using Foundation.Model.Gallery;

namespace Business
{
    public class GalleryBusiness:IGalleryBusiness
    {
        public List<Album> GetAlbums()
        {
            var albums  = new List<Album>();
            for (int i = 0; i < 10; i++)
            {
                albums.Add(new Album()
                {
                    Id = i,
                    CoverImagePath = "",
                    Description = i.ToString(),
                    Name = "Album" + i.ToString()
                });
            }
            return albums;
        }
    }
}
