using EasyShop.DataAccessLayer.Models;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace EasyShop.DataAccessLayer.NHibernate
{
    public class NHibernateHelper
    {
        private ISessionFactory sessionFactory;
        private ISession currentSession;
        public ISession GetCurrentSession()
        {
            if (currentSession == null) 
            {
                sessionFactory = 
                    Fluently.Configure()
                    .Database(
                        MsSqlConfiguration.MsSql2012.ConnectionString(@"Data Source=WIN-9KFDI3K9R34\SQLEXPRESS;Initial Catalog=EasyShop;Integrated Security=True")
                        .ShowSql()
                    )
                    .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Picture>())
                    .ExposeConfiguration(cfg => new SchemaUpdate(cfg).Execute(false, true))
                    .BuildSessionFactory();
                currentSession = sessionFactory.OpenSession();
            }
            return currentSession;
        }
    }
}
