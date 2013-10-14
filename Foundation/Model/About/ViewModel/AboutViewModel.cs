using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Model.About.ViewModel
{
    public class AboutViewModel
    {
        public AboutViewModel()
        {
            About= new About();
            AboutImageGalery = new List<AboutImageGalery>();
        }


        public About About { get; set; }

        public List<AboutImageGalery> AboutImageGalery { get; set; }
    }
}
