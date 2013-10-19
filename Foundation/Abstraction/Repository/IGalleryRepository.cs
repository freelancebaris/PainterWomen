using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation.Model.Gallery;

namespace Foundation.Abstraction.Repository
{
    public interface IGalleryRepository
    {
        List<Album> GetAlbums(Enums.Language lang);
    }
}
