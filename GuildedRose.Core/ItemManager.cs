using GuildedRose.Core.ItemWrappers;
using System.Collections.Generic;

namespace GuildedRose.Core
{
    public class ItemManager
    {
        public IList<BaseItemWrapper> Items { get; }

        public ItemManager(IList<BaseItemWrapper> Items)
        {
            this.Items = Items;
        }

        public void UpdateQuality()
        {
            foreach (var item in this.Items)
            {
                item.UpdateQuality();
            }
        }
    }
}