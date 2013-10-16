using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Abstraction.Repository
{
    using Foundation.Model.Galery;

    public interface IGaleryRepository
    {
        List<PhotoGalery> GetAllPhotoGaleries();
    }
}
