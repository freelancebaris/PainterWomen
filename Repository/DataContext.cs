namespace Repository
{
    using Foundation;

    using ServiceStack.OrmLite;

    public abstract class DataContext
    {
        protected static IOrmLiteDialectProvider DefaultProvider = SqlServerDialect.Provider;

        protected void CreateTableIfNotExists<TEntity>() where TEntity : new()
        {
            OrmLiteConfig.DialectProvider = DefaultProvider;
            var dbFactory = new OrmLiteConnectionFactory(Strings.Connection.ConnectionString, DefaultProvider);
            using (var db = dbFactory.Open())
            {
                db.CreateTableIfNotExists<TEntity>();
            }
        }

    }
}
