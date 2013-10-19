using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foundation;
using ServiceStack.OrmLite;
using ServiceStack.OrmLite.SqlServer;

namespace Repository
{
    public class BaseRepository: DataContext
    {
        public OrmLiteConnectionFactory Connection;
        public BaseRepository()
        {
            OrmLiteConfig.DialectProvider = DefaultProvider;
            var dbFactory = new OrmLiteConnectionFactory("Server=.;Database=PainterWoman;Trusted_Connection=True;");
            Connection = dbFactory;
        }
    }
}
