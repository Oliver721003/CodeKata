namespace CodeKata.Shipper
{
    public interface IShipperStrategy
    {
        double ShippingFee(double length, double width, double height, double weight);
    }
}