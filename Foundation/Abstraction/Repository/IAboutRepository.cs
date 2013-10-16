using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foundation.Abstraction.Repository
{
    using Foundation.Model.About;

    public interface IAboutRepository
    {
        About GetAboutByLang(string lang);

        List<AboutImageGalery> GetAboutImageGaleries();
    }
}
