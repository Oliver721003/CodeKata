using System;
using CodeKata.Enum;

namespace CodeKata.Shipper
{
    public static class ShipperStrategyFactory
    {
        public static IShipperStrategy CreateInstance(ShipperType shipperType)
        {
            switch (shipperType)
            {
                case ShipperType.BlackCat:
                    return new BlackCarShipper();
                case ShipperType.Hsinchu:
                    return new HsinchuShipper();
                case ShipperType.PostOffice:
                    return new PostOfficeShipper();
                default:
                    throw new ArgumentOutOfRangeException(nameof(shipperType), shipperType,
                        "Shipper type is not exist");
            }
        }
    }
}