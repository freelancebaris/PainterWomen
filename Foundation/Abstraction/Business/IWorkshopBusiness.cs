using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation.Model.Workshop;

namespace Foundation.Abstraction.Business
{
    public interface IWorkshopBusiness
    {
        List<WorkshopItem> GetTop5Workshops();
    }
}
