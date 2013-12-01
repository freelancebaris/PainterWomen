using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation.Abstraction.Repository;
using Foundation.Model.Workshop;
using ServiceStack.OrmLite;

namespace Repository
{
    public class WorkshopRepository : BaseRepository, IWorkshopRepository
    {
        public List<WorkshopItem> GetTop5Workshops(int lang)
        {
            var workshops = new List<WorkshopItem>();
            using (var db = Connection.Open())
            {
                workshops = db.Select<WorkshopItem>(ws => ws.Lang == lang)
                    .OrderByDescending(ws => ws.Id)
                    .Take(5)
                    .ToList();
            }
            
            return workshops;
        }
    }
}
