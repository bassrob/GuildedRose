using System;

namespace GuildedRose.Core.ItemWrappers
{
    public class IncreasingItemWrapper : BaseItemWrapper
    {
        public IncreasingItemWrapper(Item item)
            : base(item)
        {
        }

        public override void UpdateQuality()
        {
            this.Quality++;
            this.SellIn--;

            if (this.SellIn < 0)
            {
                this.Quality++;
            }

            this.Quality = Math.Min(this.Quality, 50);
        }
    }
}
