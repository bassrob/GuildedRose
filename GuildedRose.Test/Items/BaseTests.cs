using GuildedRose.Core;
using GuildedRose.Core.ItemWrappers;
using NUnit.Framework;
using System.Collections.Generic;

namespace GuildedRose.Test.Items
{
    public abstract class BaseTests
    {
        protected virtual void PerformTest(
            BaseItemWrapper itemWrapper,
            int expectedQuality,
            int expectedSellIn)
        {
            var manager = new ItemManager(new List<BaseItemWrapper> { itemWrapper });

            manager.UpdateQuality();

            Assert.AreEqual(expectedQuality, manager.Items[0].Quality);
            Assert.AreEqual(expectedSellIn, manager.Items[0].SellIn);
        }

        protected abstract BaseItemWrapper CreateItemWrapper(int quality, int sellIn);
    }
}
