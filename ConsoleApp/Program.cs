using System;
using CodeKata;
using CodeKata.Enum;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cart = new CartContext();
            var fee = cart.ShippingFee(ShipperType.BlackCat, 100d, 100d, 100d, 100d);
            Console.WriteLine($"運算為 {fee} 元");
        }
    }
}