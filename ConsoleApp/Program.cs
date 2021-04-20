using System;
using CodeKata;
using CodeKata.Model;
using CodeKata.Shipper;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var product = new Product {Length = 30, Width = 20, Height = 10, Weight = 5};

            var cart = new CartContext {Shipper = new BlackCarShipper()};
            var fee = cart.ShippingFee(product);

            Console.WriteLine($"運算為 {fee} 元");
        }
    }
}