using System.Configuration;
using Domain;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace DbBuilder
{
    using System;
    using NHibernate.Cfg;
    using NHibernate.Tool.hbm2ddl;

    class Program
    {
        static void Main()
        {
            MsSqlConfiguration sqlServer = MsSqlConfiguration.MsSql2008;
            sqlServer.ConnectionString(c => c.FromConnectionStringWithKey("yabe"));

            var fluentConfig = Fluently.Configure()
                .Database(sqlServer)
                .Mappings(m =>
                          m.FluentMappings.AddFromAssemblyOf<Post>());
            var config = fluentConfig.BuildConfiguration();
            SchemaExport export = new SchemaExport(config);
            export.Drop(false, false);
            export.Create(true, true);

            Console.Write("Press <ENTER> to exit...");
            Console.ReadLine();
        }
    }
}
