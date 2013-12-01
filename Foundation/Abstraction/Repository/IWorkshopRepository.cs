using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation.Model.Workshop;

namespace Foundation.Abstraction.Repository
{
    public interface IWorkshopRepository
    {
        List<WorkshopItem> GetTop5Workshops(int lang);
    }
}
