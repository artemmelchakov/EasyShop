using FluentNHibernate.Mapping;
using System;

namespace EasyShop.DataAccessLayer.Models
{
    public abstract class BaseProduct
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string Description { get; set; }
    }

    public abstract class BaseProductMap<T> : ClassMap<T> where T : BaseProduct
    { 
        protected BaseProductMap()
        {
            Id(picture => picture.Id).GeneratedBy.Guid();
            Map(picture => picture.Name);
            Map(picture => picture.Price);
            Map(picture => picture.Description);
        }
    }
}
