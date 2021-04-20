using System;
using CodeKata.Enum;
using CodeKata.Model;
using CodeKata.Shipper;

namespace CodeKata
{
    public class CartContext
    {
        public double ShippingFee(ShipperType shipperType, double length, double width, double height, double weight)
        {
            var product = new Product {Length = length, Width = width, Height = height, Weight = weight};
            return ShippingFee(shipperType, product);
        }

        public double ShippingFee(ShipperType shipperType, Product product)
        {
            IShipperStrategy shipper;

            switch (shipperType)
            {
                case ShipperType.BlackCat:
                    shipper = new BlackCarShipper();
                    break;
                case ShipperType.Hsinchu:
                    shipper = new HsinchuShipper();
                    break;
                case ShipperType.PostOffice:
                    shipper = new PostOfficeShipper();
                    break;
                default:
                    throw new ArgumentException("shipper not exist");
            }

            return shipper.ShippingFee(product);
        }
    }
}