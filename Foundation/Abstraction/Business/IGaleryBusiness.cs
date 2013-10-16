using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Abstraction.Business
{
    using Foundation.Model.Galery;
    using Foundation.Model.Galery.viewModel;

    public interface IGaleryBusiness
    {
        GaleryViewModel GaleryViewModel();

        List<PhotoGalery> GetAllPhotoGaleries();
    }
}
