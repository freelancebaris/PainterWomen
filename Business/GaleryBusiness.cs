using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    using Foundation.Abstraction.Business;
    using Foundation.Abstraction.Repository;
    using Foundation.Model.Galery;
    using Foundation.Model.Galery.viewModel;

    public class GaleryBusiness:IGaleryBusiness
    {
        private readonly IGaleryRepository _galeryRepository;

        public GaleryBusiness(IGaleryRepository galeryRepository)
        {
            this._galeryRepository = galeryRepository;
        }

        public List<PhotoGalery> GetAllPhotoGaleries()
        {
            return _galeryRepository.GetAllPhotoGaleries();
        }

        public GaleryViewModel GaleryViewModel()
        {
            var viewModel = new GaleryViewModel();
            viewModel.PhotoGaleries = GetAllPhotoGaleries();

            return viewModel;
        }
    }
}
