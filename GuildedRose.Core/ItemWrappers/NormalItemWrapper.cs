using System;

namespace GuildedRose.Core.ItemWrappers
{
    public class NormalItemWrapper : BaseItemWrapper
    {
        public NormalItemWrapper(Item item)
            : base(item)
        {
        }

        public override void UpdateQuality()
        {
            this.Quality--;
            this.SellIn--;

            if (this.SellIn < 0)
            {
                this.Quality--;
            }

            this.Quality = Math.Max(this.Quality, 0);
        }
    }
}
