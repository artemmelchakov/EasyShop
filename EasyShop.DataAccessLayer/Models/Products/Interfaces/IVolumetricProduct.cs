namespace EasyShop.DataAccessLayer.Models
{
    interface IVolumetricProduct
    {
        public float HeightCm { get; set; }
        public float WidthCm { get; set; }
        public float DepthCm { get; set; }
    }
}
