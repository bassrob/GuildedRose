namespace GuildedRose.Core.ItemWrappers
{
    public abstract class BaseItemWrapper
    {
        private Item item;

        public BaseItemWrapper(Item item)
        {
            this.item = item;
        }

        public string Name
        {
            get { return this.item.Name; }
            set { this.item.Name = value; }
        }

        public int Quality
        {
            get { return this.item.Quality; }
            set { this.item.Quality = value; }
        }

        public int SellIn
        {
            get { return this.item.SellIn; }
            set { this.item.SellIn = value; }
        }
        
        public abstract void UpdateQuality();
    }
}
