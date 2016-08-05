using System;

namespace GuildedRose.Core.ItemWrappers
{
    public class ConjuredItemWrapper : BaseItemWrapper
    {
        public ConjuredItemWrapper(Item item)
            : base(item)
        {
        }

        public override void UpdateQuality()
        {
            this.Quality -= 2;
            this.SellIn--;

            if (this.SellIn < 0)
            {
                this.Quality -= 2;
            }

            this.Quality = Math.Max(this.Quality, 0);
        }
    }
}
