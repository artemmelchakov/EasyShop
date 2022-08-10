using EasyShop.DataAccessLayer.Models.Products.Interfaces;
using FluentNHibernate.Mapping;

namespace EasyShop.DataAccessLayer.Models.Products
{
    public class Picture : BaseProduct, IFlatProduct
    {
        public virtual float HeightCm { get; set; }
        public virtual float WidthCm { get; set; }
        public virtual string PaintingName { get; set; }
        public virtual string PaintingTechnique { get; set; }
        public virtual string PaintingGenre { get; set; }
    }

    public class PictureMap : BaseProductMap<Picture>
    {
        public PictureMap() : base()
        {
            /*Id(picture => picture.Id).GeneratedBy.Guid();
            Map(picture => picture.Name);
            Map(picture => picture.Price);
            Map(picture => picture.Description);*/

            Map(picture => picture.HeightCm);
            Map(picture => picture.WidthCm);
            Map(picture => picture.PaintingName);
            Map(picture => picture.PaintingTechnique);
            Map(picture => picture.PaintingGenre);
        }
    }
}
