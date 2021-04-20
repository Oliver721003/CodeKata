using CodeKata.Model;

namespace CodeKata.Shipper
{
    public interface IShipperStrategy
    {
        double ShippingFee(Product product);
    }
}