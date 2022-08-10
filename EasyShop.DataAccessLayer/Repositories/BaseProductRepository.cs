using EasyShop.DataAccessLayer.NHibernate;
using EasyShop.DataAccessLayer.Models.Products;
using NHibernate;
using System;
using System.Collections.Generic;

namespace EasyShop.DataAccessLayer.Repositories
{
    public class BaseProductRepository<T> : IRepository where T : BaseProduct
    {
        private static ISession session;
        public BaseProductRepository() 
        {
            session = new NHibernateHelper().GetCurrentSession();
        }
        public virtual IEnumerable<T> GetList()
        {
            return session.QueryOver<T>().List();
        }
        public virtual T Get(Guid id) => session.Get<T>(id);
        public virtual void Create(T entity)
        {
            using (var transaction = session.BeginTransaction())
            {
                try
                {
                    session.Save(entity);
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
