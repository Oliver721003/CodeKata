using CodeKata.Model;

namespace CodeKata.Shipper
{
    public class BlackCarShipper: IShipperStrategy
    {
        public double ShippingFee(Product product)
        {
            return product.Weight > 20 ? 500 : 100 + product.Weight * 10;
        }
    }
}