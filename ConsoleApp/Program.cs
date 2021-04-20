using System;
using CodeKata;
using CodeKata.Enum;
using CodeKata.Model;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cart = new CartContext();
            var product = new Product {Length = 30, Width = 20, Height = 10, Weight = 5};
            var fee = cart.ShippingFee(ShipperType.BlackCat, product);
            Console.WriteLine($"運算為 {fee} 元");
        }
    }
}