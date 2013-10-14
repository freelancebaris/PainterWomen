using ServiceStack.OrmLite;

namespace Foundation
{
    public abstract class DataContext
    {
        protected static string SqliteFileDb = Strings.Connection.ConnectionString;
        protected static IOrmLiteDialectProvider DefaultProvider = SqlServerDialect.Provider;
        public static string DefaultConnection = SqliteFileDb;

        protected void CreateTableIfNotExists<TEntity>() where TEntity : new()
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
