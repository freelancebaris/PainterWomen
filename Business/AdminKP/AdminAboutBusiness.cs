using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.AdminKP
{
    using Foundation.Abstraction.Business.AdminKP;
    using Foundation.Abstraction.Repository.AdminKP;
    using Foundation.Model.About;

    public class AdminAboutBusiness : IAdminAboutBusiness
    {
        private readonly IAdminAboutRepository _aboutAdminRepository;

        public AdminAboutBusiness(IAdminAboutRepository aboutAdminRepository)
        {
            _aboutAdminRepository = aboutAdminRepository;
        }

        public About GetAbout()
        {
            About about = _aboutAdminRepository.GetAbout();

            return about;
        }
    }
}
