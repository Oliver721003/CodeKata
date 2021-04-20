using System;
using CodeKata.Enum;
using CodeKata.Model;
using CodeKata.Shipper;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var product = new Product {Length = 30, Width = 20, Height = 10, Weight = 5};

            var shipper = ShipperStrategyFactory.CreateInstance(ShipperType.BlackCat);
            var fee = shipper.ShippingFee(product);

            Console.WriteLine($"運算為 {fee} 元");
        }
    }
}