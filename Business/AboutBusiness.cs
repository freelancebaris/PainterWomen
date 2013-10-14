using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    using Foundation.Abstraction.Business;
    using Foundation.Abstraction.Repository;
    using Foundation.Model.About;

    public class AboutBusiness : IAboutBusiness
    {
        private readonly IAboutRepository _aboutRepository;

        public AboutBusiness(IAboutRepository aboutRepository)
        {
            this._aboutRepository = aboutRepository;
        }

        public About GetAboutByLang(string lang)
        {
            var about = _aboutRepository.GetAboutByLang(lang);
            if (about == null)
            {
                about = new About
                        {
                            Content1 = "",
                            Content2 = "",
                            Content3 = "",
                            Title = "",
                            ImageUrl1 = "",
                            ImageUrl2 = "",
                            ImageUrl3 = ""
                        };
            }

            return about;
        }
    }
}
