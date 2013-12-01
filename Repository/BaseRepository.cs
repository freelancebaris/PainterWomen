using Foundation;
using ServiceStack.OrmLite;

namespace Repository
{
    public class BaseRepository: DataContext
    {
        public OrmLiteConnectionFactory Connection;
        public BaseRepository()
        {
            OrmLiteConfig.DialectProvider = DefaultProvider;
            var dbFactory = new OrmLiteConnectionFactory(Strings.Connection.ConnectionString);
            Connection = dbFactory;
        }
    }
}
