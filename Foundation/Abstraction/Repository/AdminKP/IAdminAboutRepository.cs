using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Abstraction.Repository.AdminKP
{
    using Foundation.Model.About;

    public interface IAdminAboutRepository
    {
        About GetAbout();
    }
}
