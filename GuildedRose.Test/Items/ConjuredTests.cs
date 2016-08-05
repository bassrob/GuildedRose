using GuildedRose.Core.ItemWrappers;
using NUnit.Framework;
using GuildedRose.Core;

namespace GuildedRose.Test.Items
{
    [TestFixture]
    public class ConjuredTests : BaseTests
    {
        [TestCase(1, 1, 0, 0)]
        [TestCase(10, 1, 8, 0)]
        public void NormalItems_Decrease(
            int quality,
            int sellIn,
            int expectedQuality,
            int expectedSellIn)
        {
            this.PerformTest(this.CreateItemWrapper(quality, sellIn), expectedQuality, expectedSellIn);
        }

        [TestCase(10, 0, 6, -1)]
        [TestCase(10, -1, 6, -2)]
        public void NormalItems_Decrease2x_IfSellInIsNegative(
            int quality,
            int sellIn,
            int expectedQuality,
            int expectedSellIn)
        {
            this.PerformTest(this.CreateItemWrapper(quality, sellIn), expectedQuality, expectedSellIn);
        }

        [TestCase(1, -1, 0, -2)]
        [TestCase(0, -1, 0, -2)]
        [TestCase(1, 1, 0, 0)]
        public void NormalItems_DoNotGoBelow0(
            int quality,
            int sellIn,
            int expectedQuality,
            int expectedSellIn)
        {
            this.PerformTest(this.CreateItemWrapper(quality, sellIn), expectedQuality, expectedSellIn);
        }

        protected override BaseItemWrapper CreateItemWrapper(int quality, int sellIn)
        {
            return new ConjuredItemWrapper(new Item
            {
                Name = Constants.CONJURED,
                Quality = quality,
                SellIn = sellIn,
            });
        }
    }
}
