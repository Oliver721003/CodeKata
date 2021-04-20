using System;
using CodeKata.Enum;
using CodeKata.Shipper;

namespace CodeKata
{
    public class CartContext
    {
        public double ShippingFee(ShipperType shipperType, double length, double width, double height, double weight)
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

            return shipper.ShippingFee(length, width, height, weight);
        }
    }
}