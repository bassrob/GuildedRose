using System;
using System.Collections.Generic;

namespace GuildedRose.Core
{
    public class ItemManager
    {
        public IList<Item> Items { get; }

        public ItemManager(IList<Item> Items)
        {
            this.Items = Items;
        }

        private void UpdateIncreasing(Item item)
        {
            item.Quality++;
            item.SellIn--;

            if (item.SellIn < 0)
            {
                item.Quality++;
            }

            item.Quality = Math.Min(item.Quality, 50);
        }

        private void UpdateBackstagePass(Item item)
        {
            if (item.SellIn < 6)
            {
                item.Quality += 3;
            }
            else if (item.SellIn < 11)
            {
                item.Quality += 2;
            }
            else
            {
                item.Quality++;
            }

            item.SellIn--;
            item.Quality = Math.Min(item.Quality, 50);

            if (item.SellIn < 0)
            {
                item.Quality = 0;
            }
        }

        public void UpdateLegendary(Item item)
        {
        }

        public void UpdateOther(Item item)
        {
            item.Quality--;
            item.SellIn--;

            if (item.SellIn < 0)
            {
                item.Quality--;
            }

            item.Quality = Math.Max(item.Quality, 0);
        }

        public void UpdateQuality()
        {
            foreach (var item in this.Items)
            {
                switch (item.Name)
                {
                    case Constants.INCREASING:
                        UpdateIncreasing(item);
                        break;
                    case Constants.BACKSTAGE_PASS:
                        UpdateBackstagePass(item);
                        break;
                    case Constants.LEGENDARY:
                        UpdateLegendary(item);
                        break;
                    default:
                        UpdateOther(item);
                        break;
                }
            }
        }
    }
}