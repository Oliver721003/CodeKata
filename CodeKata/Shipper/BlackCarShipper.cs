namespace CodeKata.Shipper
{
    public class BlackCarShipper: IShipperStrategy
    {
        public double ShippingFee(double length, double width, double height, double weight)
        {
            return weight > 20 ? 500 : 100 + weight * 10;
        }
    }
}