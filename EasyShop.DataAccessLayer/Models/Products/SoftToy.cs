using FluentNHibernate.Mapping;

namespace EasyShop.DataAccessLayer.Models
{
    public class SoftToy : BaseProduct, IVolumetricProduct
    {
        public virtual float HeightCm { get; set; }
        public virtual float WidthCm { get; set; }
        public virtual float DepthCm { get; set; }
        public virtual string Material { get; set; }
    }

    public class SoftToyMap : BaseProductMap<SoftToy>
    {
        public SoftToyMap()
        {
            Map(softToy => softToy.HeightCm);
            Map(softToy => softToy.WidthCm);
            Map(softToy => softToy.DepthCm);
            Map(softToy => softToy.Material);
        }
    }
}
