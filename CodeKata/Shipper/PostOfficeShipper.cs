using System;
using CodeKata.Model;

namespace CodeKata.Shipper
{
    public class PostOfficeShipper : IShipperStrategy
    {
        public double ShippingFee(Product product)
        {
            var feeByWeight = 80 + product.Weight * 10;
            var feeBySize = product.Size * 0.00002 * 1100;
            return Math.Min(feeByWeight, feeBySize);
        }
    }
}