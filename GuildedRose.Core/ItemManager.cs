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

        public void UpdateQuality()
        {
            foreach (var item in this.Items)
            {
                if (item.Name != Constants.INCREASING && item.Name != Constants.BACKSTAGE_PASS)
                {
                    if (item.Quality > 0)
                    {
                        if (item.Name != Constants.LEGENDARY)
                        {
                            item.Quality--;
                        }
                    }
                }
                else
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
                }

                if (item.Name != Constants.LEGENDARY)
                {
                    item.SellIn--;
                }

                if (item.SellIn < 0)
                {
                    if (item.Name != Constants.INCREASING)
                    {
                        if (item.Name != Constants.BACKSTAGE_PASS)
                        {
                            if (item.Quality > 0)
                            {
                                if (item.Name != Constants.LEGENDARY)
                                {
                                    item.Quality--;
                                }
                            }
                        }
                        else
                        {
                            item.Quality = 0;
                        }
                    }
                    else
                    {
                        if (item.Quality < 50)
                        {
                            item.Quality++;
                        }
                    }
                }
            }
        }
    }
}