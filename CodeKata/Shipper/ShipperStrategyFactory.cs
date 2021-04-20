using System;
using CodeKata.Enum;
using CodeKata.Model;

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

        public static Func<Product, double> GetShippingFeeFunction(ShipperType shipperType)
        {
            switch (shipperType)
            {
                case ShipperType.BlackCat:
                    return (product) => product.Weight > 20 ? 500 : 100 + product.Weight * 10;
                case ShipperType.Hsinchu:
                    return (product) =>
                    {
                        var size = product.Length * product.Width * product.Height;
                        if (product.Length > 100 || product.Width > 100 || product.Height > 100)
                            return size * 0.00002 * 1100 + 500;
                        else
                            return size * 0.00002 * 1200;
                    };
                case ShipperType.PostOffice:
                    return (product) =>
                    {
                        var feeByWeight = 80 + product.Weight * 10;
                        var size = product.Length * product.Width * product.Height;
                        var feeBySize = size * 0.00002 * 1100;
                        return feeByWeight < feeBySize ? feeByWeight : feeBySize;
                    };
                default:
                    throw new ArgumentOutOfRangeException(nameof(shipperType), shipperType,
                        "Shipper type is not exist");
            }
        }
    }
}