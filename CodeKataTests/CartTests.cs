using CodeKata;
using NUnit.Framework;

namespace CodeKataTests
{
    [TestFixture]
    public class CartTests
    {
        private readonly CartContext _cart = new CartContext();

        private const string BlackCat = "black cat";
        private const string Hsinchu = "hsinchu";
        private const string PostOffice = "post office";

        [Test]
        public void black_cat_with_light_weight()
        {
            var actual = _cart.ShippingFee(BlackCat, 30, 20, 10, 5);
            Assert.AreEqual(150, actual);
        }

        [Test]
        public void black_cat_with_heavy_weight()
        {
            var actual = _cart.ShippingFee(BlackCat, 30, 20, 10, 50);
            Assert.AreEqual(500, actual);
        }

        [Test]
        public void hsinchu_with_small_size()
        {
            var actual = _cart.ShippingFee(Hsinchu, 30, 20, 10, 50);
            Assert.AreEqual(144, actual);
        }

        [Test]
        public void hsinchu_with_huge_size()
        {
            var actual = _cart.ShippingFee(Hsinchu, 100, 20, 10, 50);
            Assert.AreEqual(480, actual);
        }

        [Test]
        public void post_office_by_weight()
        {
            var actual = _cart.ShippingFee(PostOffice, 100, 20, 10, 3);
            Assert.AreEqual(110, actual);
        }

        [Test]
        public void post_office_by_size()
        {
            var actual = _cart.ShippingFee(PostOffice, 100, 20, 10, 300);
            Assert.AreEqual(440, actual);
        }
    }
}