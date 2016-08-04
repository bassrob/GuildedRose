using GuildedRose.Core;
using NUnit.Framework;

namespace GuildedRose.Test.Items
{
    [TestFixture]
    public class AgedBrieTests : BaseTests
    {
        protected override string ItemType { get { return Constants.INCREASING; } }

        [TestCase(10, 10, 11, 9)]
        [TestCase(10, 1, 11, 0)]
        public void AgedBrie_IncreasesWithAge_WhenSellInIsPositive(
               int quality,
               int sellIn,
               int expectedQuality,
               int expectedSellIn)
        {
            this.PerformTests(quality, sellIn, expectedQuality, expectedSellIn);
        }

        [TestCase(10, 0, 12, -1)]
        [TestCase(10, -1, 12, -2)]
        public void AgedBrie_IncreasesWithAge2x_WhenSellInIsZeroOrNegative(
               int quality,
               int sellIn,
               int expectedQuality,
               int expectedSellIn)
        {
            this.PerformTests(quality, sellIn, expectedQuality, expectedSellIn);
        }

        [TestCase(48, 0, 50, -1)]
        [TestCase(49, 1, 50, 0)]
        [TestCase(49, 0, 50, -1)]
        [TestCase(50, 1, 50, 0)]
        [TestCase(50, 0, 50, -1)]
        public void AgedBrie_DoesNotIncreaseBeyond50(
               int quality,
               int sellIn,
               int expectedQuality,
               int expectedSellIn)
        {
            this.PerformTests(quality, sellIn, expectedQuality, expectedSellIn);
        }
    }
}
