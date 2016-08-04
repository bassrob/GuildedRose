using GuildedRose.Core;
using NUnit.Framework;

namespace GuildedRose.Test.Items
{
    [TestFixture]
    public class SufurasTests : BaseTests
    {
        protected override string ItemType { get { return Constants.LEGENDARY; } }

        [TestCase(80, 10, 80, 10)]
        [TestCase(80, 1, 80, 1)]
        [TestCase(80, 0, 80, 0)]
        [TestCase(80, -1, 80, -1)]
        [TestCase(50, 10, 50, 10)]
        [TestCase(49, 10, 49, 10)]
        public void Sufuras_QualityDoesNotIncrease(
               int quality,
               int sellIn,
               int expectedQuality,
               int expectedSellIn)
        {
            this.PerformTests(quality, sellIn, expectedQuality, expectedSellIn);
        }

        [TestCase(80, 10, 80, 10)]
        [TestCase(80, 1, 80, 1)]
        [TestCase(80, 0, 80, 0)]
        [TestCase(80, -1, 80, -1)]
        [TestCase(50, 10, 50, 10)]
        [TestCase(49, 10, 49, 10)]
        public void Sufuras_SellInDoesNotDecrease(
               int quality,
               int sellIn,
               int expectedQuality,
               int expectedSellIn)
        {
            this.PerformTests(quality, sellIn, expectedQuality, expectedSellIn);
        }
    }
}
