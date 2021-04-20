using System;
using CodeKata;

namespace ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cart = new CartContext();
            var fee = cart.ShippingFee("black cat", 100d, 100d, 100d, 100d);
            Console.WriteLine($"運算為 {fee} 元");
        }
    }
}