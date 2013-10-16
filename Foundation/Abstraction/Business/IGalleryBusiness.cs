using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation.Model.Gallery;

namespace Foundation.Abstraction.Business
{
    public interface IGalleryBusiness
    {
        List<Album> GetAlbums();
    }
}
