using CodeKata.Model;

namespace CodeKata.Shipper
{
    public class HsinchuShipper : IShipperStrategy
    {
        public double ShippingFee(Product product)
        {
            var size = product.Length * product.Width * product.Height;
            if (product.Length > 100 || product.Width > 100 || product.Height > 100)
                return size * 0.00002 * 1100 + 500;
            else
                return size * 0.00002 * 1200;
        }
    }
}