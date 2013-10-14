using ServiceStack.OrmLite;

namespace Foundation
{
    public class DataContext
    {
        public static string SqliteFileDb = Strings.Connection.ConnectionString;
        public static IOrmLiteDialectProvider DefaultProvider = SqlServerDialect.Provider;
        public static string DefaultConnection = SqliteFileDb;

        public void CreateTableIfNotExists<TEntity>() where TEntity : new()
        {
            OrmLiteConfig.DialectProvider = DefaultProvider;
            var dbFactory = new OrmLiteConnectionFactory(SqliteFileDb, DefaultProvider);
            using (var db = dbFactory.Open())
            {
                db.CreateTableIfNotExists<TEntity>();
            }
        }
    }
}
