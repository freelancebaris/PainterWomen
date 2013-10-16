using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Abstraction.Business
{
    using Foundation.Model.About;
    using Foundation.Model.About.ViewModel;

    public  interface IAboutBusiness
    {
        AboutViewModel GetAboutByLang(string lang);
    }
}
