using System;
using CodeKata.Enum;

namespace CodeKata
{
    public class CartContext
    {
        public double ShippingFee(ShipperType shipperType, double length, double width, double height, double weight)
        {
            switch (shipperType)
            {
                case ShipperType.BlackCat:
                    return weight > 20 ? 500 : 100 + weight * 10;
                case ShipperType.Hsinchu:
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
                case ShipperType.PostOffice:
                {
                    var feeByWeight = 80 + weight * 10;
                    var size = length * width * height;
                    var feeBySize = size * 0.00002 * 1100;
                    return feeByWeight < feeBySize ? feeByWeight : feeBySize;
                }
                default:
                    throw new ArgumentException("shipper not exist");
            }
        }
    }
}