using CodeKata.Model;

namespace CodeKata.Shipper
{
    public class PostOfficeShipper : IShipperStrategy
    {
        public double ShippingFee(Product product)
        {
            var feeByWeight = 80 + product.Weight * 10;
            var size = product.Length * product.Width * product.Height;
            var feeBySize = size * 0.00002 * 1100;
            return feeByWeight < feeBySize ? feeByWeight : feeBySize;
        }
    }
}