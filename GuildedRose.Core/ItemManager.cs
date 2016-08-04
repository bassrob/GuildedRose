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
            if (item.Quality < 50)
            {
                item.Quality++;
            }

            item.SellIn--;

            if (item.SellIn < 0)
            {
                if (item.Quality < 50)
                {
                    item.Quality++;
                }
            }
        }

        private void UpdateBackstagePass(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality++;

                if (item.Name == Constants.BACKSTAGE_PASS)
                {
                    if (item.SellIn < 11)
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality++;
                        }
                    }

                    if (item.SellIn < 6)
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality++;
                        }
                    }
                }
            }

            item.SellIn--;

            if (item.SellIn < 0)
            {
                if (item.Name != Constants.INCREASING)
                {
                    item.Quality = 0;
                }
            }
        }

        public void UpdateLegendary(Item item)
        {
        }

        public void UpdateOther(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality--;
            }

            item.SellIn--;

            if (item.SellIn < 0)
            {
                if (item.Quality > 0)
                {
                    item.Quality--;
                }
            }
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