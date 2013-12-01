using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation.Abstraction.Business;
using Foundation.Abstraction.Repository;
using Foundation.Abstraction.Services;
using Foundation.Model.Workshop;

namespace Business
{
    public class WorkshopBusiness : IWorkshopBusiness
    {
        private readonly IWorkshopRepository _repository;
        private readonly ISessionHelper _sessionHelper;
        public WorkshopBusiness(IWorkshopRepository repository, ISessionHelper sessionHelper)
        {
            _repository = repository;
            _sessionHelper = sessionHelper;
        }

        public List<WorkshopItem> GetTop5Workshops()
        {
            var lang = _sessionHelper.UserContext.SelectedLanguage;
            var workshops = _repository.GetTop5Workshops((int) lang);
            return workshops;
        }
    }
}
