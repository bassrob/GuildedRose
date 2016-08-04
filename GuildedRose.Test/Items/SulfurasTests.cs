using GuildedRose.Core;
using GuildedRose.Core.ItemWrappers;
using NUnit.Framework;

namespace GuildedRose.Test.Items
{
    [TestFixture]
    public class SufurasTests : BaseTests
    {
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
            this.PerformTest(this.CreateItemWrapper(quality, sellIn), expectedQuality, expectedSellIn);
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
            this.PerformTest(this.CreateItemWrapper(quality, sellIn), expectedQuality, expectedSellIn);
        }

        protected override BaseItemWrapper CreateItemWrapper(int quality, int sellIn)
        {
            return new LegendaryItemWrapper(new Item
            {
                Name = Constants.LEGENDARY,
                Quality = quality,
                SellIn = sellIn,
            });
        }
    }
}
