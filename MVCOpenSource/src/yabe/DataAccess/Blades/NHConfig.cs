using Domain;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;

namespace DataAccess.Blades
{
    public static class NHConfig
    {
        private static FluentConfiguration fluentConfig;
        private static ISessionFactory sessionFactory;

        public static void Initialize()
        {
            MsSqlConfiguration sqlServer = MsSqlConfiguration.MsSql2008;
            sqlServer.ConnectionString(c => c.FromConnectionStringWithKey("yabe"));

            fluentConfig = Fluently.Configure()
                .Database(sqlServer)
                .Mappings(m =>
                          m.FluentMappings.AddFromAssemblyOf<Post>());
        }

        public static void CreateSessionFactory()
        {
            sessionFactory = fluentConfig.BuildSessionFactory();
        }

        public static ISession GetSession()
        {
            return sessionFactory.OpenSession();
        }
    }
}