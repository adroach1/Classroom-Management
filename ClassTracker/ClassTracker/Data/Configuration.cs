using System;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Linq;
using NHibernate.Tool.hbm2ddl;
using System.Data.SQLite;

namespace ClassTracker.Data
{
    public class Configuration
    {
        ISessionFactory sessionFactory;

        public Configuration Configure()
        {
            var config = SQLiteConfiguration.Standard.
                    ConnectionString(
                    c => c.FromConnectionStringWithKey("SQLiteDB"))
                    .ShowSql();

            sessionFactory = Fluently.Configure()
                .Database(config)
                .Mappings(x =>
                    x.FluentMappings.AddFromAssemblyOf<ClassTracker.Data.CourseMapping>()
                    )
                .ExposeConfiguration(BuildSchema)
                .BuildSessionFactory();

            return this;
        }

        private void BuildSchema(NHibernate.Cfg.Configuration config)
        {
            new SchemaExport(config)
                .Create(false, true);
        }

        public ISession OpenSession()
        {
            if (sessionFactory == null)
                Configure();
            return sessionFactory.OpenSession();
        }
    }
}
