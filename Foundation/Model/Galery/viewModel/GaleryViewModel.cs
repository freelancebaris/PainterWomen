using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Model.Galery.viewModel
{
    public class GaleryViewModel
    {

        public GaleryViewModel()
        {
            PhotoGaleries = new List<PhotoGalery>();
        }

        public List<PhotoGalery> PhotoGaleries { get; set; }
    }
}
