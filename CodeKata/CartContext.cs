using System;
using CodeKata.Enum;
using CodeKata.Model;
using CodeKata.Shipper;

namespace CodeKata
{
    public class CartContext
    {
        public IShipperStrategy Shipper { get; set; }

        public double ShippingFee(double length, double width, double height, double weight)
        {
            var product = new Product {Length = length, Width = width, Height = height, Weight = weight};
            return ShippingFee(product);
        }

        public double ShippingFee(Product product)
        {
            if (Shipper == null)
                throw new ArgumentException("shipper is not exist");

            return Shipper.ShippingFee(product);
        }
    }
}