using FluentNHibernate.Mapping;

namespace EasyShop.DataAccessLayer.Models
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
            Map(picture => picture.HeightCm);
            Map(picture => picture.WidthCm);
            Map(picture => picture.PaintingName);
            Map(picture => picture.PaintingTechnique);
            Map(picture => picture.PaintingGenre);
        }
    }
}
