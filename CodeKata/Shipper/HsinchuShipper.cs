namespace CodeKata.Shipper
{
    public class HsinchuShipper : IShipperStrategy
    {
        public double ShippingFee(double length, double width, double height, double weight)
        {
            var size = length * width * height;
            if (length > 100 || width > 100 || height > 100)
            {
                return size * 0.00002 * 1100 + 500;
            }
            else
            {
                return size * 0.00002 * 1200;
            }
        }
    }
}