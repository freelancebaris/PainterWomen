using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Abstraction.Business.AdminKP
{
    using Foundation.Model.About;

    public interface IAdminAboutBusiness
    {
        About GetAbout();
    }
}
