using System;

namespace GuildedRose.Core.ItemWrappers
{
    public class BackstagePassItemWrapper : BaseItemWrapper
    {
        public BackstagePassItemWrapper(Item item)
            : base(item)
        {
        }

        public override void UpdateQuality()
        {
            if (this.SellIn < 6)
            {
                this.Quality += 3;
            }
            else if (this.SellIn < 11)
            {
                this.Quality += 2;
            }
            else
            {
                this.Quality++;
            }

            this.SellIn--;
            this.Quality = Math.Min(this.Quality, 50);

            if (this.SellIn < 0)
            {
                this.Quality = 0;
            }
        }
    }
}
