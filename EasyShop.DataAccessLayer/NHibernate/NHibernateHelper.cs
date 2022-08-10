using EasyShop.DataAccessLayer.Models.Products;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Dialect;
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
                    Fluently.Configure().
                    Database
                    (
                        MsSqlConfiguration.MsSql2012.ConnectionString(
                            @"Data Source=WIN-9KFDI3K9R34\SQLEXPRESS;Initial Catalog=EasyShop;Integrated Security=SSPI;"
                            ).ShowSql().Dialect<MsSql2012Dialect>()
                    ).
                    Mappings
                    (
                        m => m.FluentMappings.AddFromAssemblyOf<BaseProduct>()
                    ).
                    ExposeConfiguration
                    (
                        cfg => new SchemaExport(cfg).Execute(false, true, true)//Create(false, false)
                    ).
                    BuildSessionFactory();
                
                currentSession = sessionFactory.OpenSession();
            }
            return currentSession;
        }
    }
}
