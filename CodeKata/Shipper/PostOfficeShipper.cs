namespace CodeKata.Shipper
{
    public class PostOfficeShipper : IShipperStrategy
    {
        public double ShippingFee(double length, double width, double height, double weight)
        {
            var feeByWeight = 80 + weight * 10;
            var size = length * width * height;
            var feeBySize = size * 0.00002 * 1100;
            return feeByWeight < feeBySize ? feeByWeight : feeBySize;
        }
    }
}