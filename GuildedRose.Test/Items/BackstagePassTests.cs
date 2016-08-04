using System;
using NUnit.Framework;
using GuildedRose.Core;

namespace GuildedRose.Test.Items
{
    [TestFixture]
    public class BackstagePassTests : BaseTests
    {
        protected override string ItemType { get { return Constants.BACKSTAGE_PASS; } }

        [TestCase(10, 11, 11, 10)]
        [TestCase(10, 12, 11, 11)]
        public void BackstagePasses_IncreasesWithAge_WhenSellInIsGreaterThan11(
               int quality,
               int sellIn,
               int expectedQuality,
               int expectedSellIn)
        {
            this.PerformTests(quality, sellIn, expectedQuality, expectedSellIn);
        }

        [TestCase(10, 10, 12, 9)]
        [TestCase(10, 6, 12, 5)]
        public void BackstagePasses_IncreasesWithAge2x_WhenSellIsLessThan11AndGreaterThan5(
               int quality,
               int sellIn,
               int expectedQuality,
               int expectedSellIn)
        {
            this.PerformTests(quality, sellIn, expectedQuality, expectedSellIn);
        }

        [TestCase(10, 5, 13, 4)]
        [TestCase(10, 1, 13, 0)]
        public void BackstagePasses_IncreasesWithAge3x_WhenSellIsLessThan6(
               int quality,
               int sellIn,
               int expectedQuality,
               int expectedSellIn)
        {
            this.PerformTests(quality, sellIn, expectedQuality, expectedSellIn);
        }

        [TestCase(10, 0, 0, -1)]
        public void BackstagePasses_DropToZero_WhenSellInIsZero(
               int quality,
               int sellIn,
               int expectedQuality,
               int expectedSellIn)
        {
            this.PerformTests(quality, sellIn, expectedQuality, expectedSellIn);
        }

        [TestCase(0, -1, 0, -2)]
        public void BackstagePasses_DoesNotGoBelow0_WhenSellInIsLessThan0(
               int quality,
               int sellIn,
               int expectedQuality,
               int expectedSellIn)
        {
            this.PerformTests(quality, sellIn, expectedQuality, expectedSellIn);
        }

        [TestCase(49, 11, 50, 10)]
        [TestCase(50, 11, 50, 10)]
        [TestCase(48, 10, 50, 9)]
        [TestCase(49, 10, 50, 9)]
        [TestCase(50, 10, 50, 9)]
        [TestCase(47, 5, 50, 4)]
        [TestCase(48, 5, 50, 4)]
        [TestCase(49, 5, 50, 4)]
        [TestCase(50, 5, 50, 4)]
        public void BackstagePasses_DoesNotIncreaseBeyond50(
               int quality,
               int sellIn,
               int expectedQuality,
               int expectedSellIn)
        {
            this.PerformTests(quality, sellIn, expectedQuality, expectedSellIn);
        }
    }
}
