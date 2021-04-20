using System;
using CodeKata.Enum;

namespace CodeKata
{
    public class CartContext
    {
        public double ShippingFee(ShipperType shipper, double length, double width, double height, double weight)
        {
            if (shipper == ShipperType.BlackCat)
            {
                if (weight > 20)
                {
                    return 500;
                }
                else
                {
                    return 100 + weight * 10;
                }
            }
            else if (shipper == ShipperType.Hsinchu)
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
            else if (shipper == ShipperType.PostOffice)
            {
                var feeByWeight = 80 + weight * 10;
                var size = length * width * height;
                var feeBySize = size * 0.00002 * 1100;
                return feeByWeight < feeBySize ? feeByWeight : feeBySize;
            }
            else
            {
                throw new ArgumentException("shipper not exist");
            }
        }
    }
}