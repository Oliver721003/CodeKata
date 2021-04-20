using CodeKata.Enum;
using CodeKata.Model;
using CodeKata.Shipper;
using NUnit.Framework;

namespace CodeKataTests
{
    [TestFixture]
    public class CartTests
    {
        [Test]
        public void black_cat_with_light_weight()
        {
            var shipper = ShipperStrategyFactory.CreateInstance(ShipperType.BlackCat);
            var product = new Product {Length = 30, Width = 20, Height = 10, Weight = 5};
            var actual = shipper.ShippingFee(product);
            Assert.AreEqual(150, actual);
        }

        [Test]
        public void black_cat_with_heavy_weight()
        {
            var shipper = ShipperStrategyFactory.CreateInstance(ShipperType.BlackCat);
            var product = new Product {Length = 30, Width = 20, Height = 10, Weight = 50};
            var actual = shipper.ShippingFee(product);
            Assert.AreEqual(500, actual);
        }

        [Test]
        public void hsinchu_with_small_size()
        {
            var shipper = ShipperStrategyFactory.CreateInstance(ShipperType.Hsinchu);
            var product = new Product {Length = 30, Width = 20, Height = 10, Weight = 50};
            var actual = shipper.ShippingFee(product);
            Assert.AreEqual(144, actual);
        }

        [Test]
        public void hsinchu_with_huge_size()
        {
            var shipper = ShipperStrategyFactory.CreateInstance(ShipperType.Hsinchu);
            var product = new Product {Length = 100, Width = 20, Height = 10, Weight = 50};
            var actual = shipper.ShippingFee(product);
            Assert.AreEqual(480, actual);
        }

        [Test]
        public void post_office_by_weight()
        {
            var shipper = ShipperStrategyFactory.CreateInstance(ShipperType.PostOffice);
            var product = new Product {Length = 100, Width = 20, Height = 10, Weight = 3};
            var actual = shipper.ShippingFee(product);
            Assert.AreEqual(110, actual);
        }

        [Test]
        public void post_office_by_size()
        {
            var shipper = ShipperStrategyFactory.CreateInstance(ShipperType.PostOffice);
            var product = new Product {Length = 100, Width = 20, Height = 10, Weight = 300};
            var actual = shipper.ShippingFee(product);
            Assert.AreEqual(440, actual);
        }
    }
}