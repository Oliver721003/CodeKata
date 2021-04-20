using CodeKata;
using CodeKata.Enum;
using CodeKata.Shipper;
using NUnit.Framework;

namespace CodeKataTests
{
    [TestFixture]
    public class CartTests
    {
        private readonly CartContext _cart = new CartContext();

        [Test]
        public void black_cat_with_light_weight()
        {
            _cart.Shipper = ShipperStrategyFactory.CreateInstance(ShipperType.BlackCat);
            var actual = _cart.ShippingFee(30, 20, 10, 5);
            Assert.AreEqual(150, actual);
        }

        [Test]
        public void black_cat_with_heavy_weight()
        {
            _cart.Shipper = ShipperStrategyFactory.CreateInstance(ShipperType.BlackCat);
            var actual = _cart.ShippingFee(30, 20, 10, 50);
            Assert.AreEqual(500, actual);
        }

        [Test]
        public void hsinchu_with_small_size()
        {
            _cart.Shipper = ShipperStrategyFactory.CreateInstance(ShipperType.Hsinchu);
            var actual = _cart.ShippingFee(30, 20, 10, 50);
            Assert.AreEqual(144, actual);
        }

        [Test]
        public void hsinchu_with_huge_size()
        {
            _cart.Shipper = ShipperStrategyFactory.CreateInstance(ShipperType.Hsinchu);
            var actual = _cart.ShippingFee(100, 20, 10, 50);
            Assert.AreEqual(480, actual);
        }

        [Test]
        public void post_office_by_weight()
        {
            _cart.Shipper = ShipperStrategyFactory.CreateInstance(ShipperType.PostOffice);
            var actual = _cart.ShippingFee(100, 20, 10, 3);
            Assert.AreEqual(110, actual);
        }

        [Test]
        public void post_office_by_size()
        {
            _cart.Shipper = ShipperStrategyFactory.CreateInstance(ShipperType.PostOffice);
            var actual = _cart.ShippingFee(100, 20, 10, 300);
            Assert.AreEqual(440, actual);
        }
    }
}