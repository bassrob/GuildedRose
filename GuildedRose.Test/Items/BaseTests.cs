using GuildedRose.Core;
using NUnit.Framework;
using System.Collections.Generic;

namespace GuildedRose.Test.Items
{
    public abstract class BaseTests
    {
        protected virtual void PerformTests(
            int quality,
            int sellIn,
            int expectedQuality,
            int expectedSellIn)
        {
            var manager = new ItemManager(new List<Item>
            {
                new Item { Name = this.ItemType, Quality = quality, SellIn = sellIn, },
            });

            manager.UpdateQuality();

            Assert.AreEqual(expectedQuality, manager.Items[0].Quality);
            Assert.AreEqual(expectedSellIn, manager.Items[0].SellIn);
        }

        protected abstract string ItemType { get; }
    }
}
