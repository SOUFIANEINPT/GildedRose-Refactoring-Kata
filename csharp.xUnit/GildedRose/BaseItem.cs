using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public abstract class BaseItem
    {
        protected Item Item { get; }
        protected BaseItem(Item item)
        {
            Item = item;
        }
        public virtual void UpdateQuality()
        {
            if (Item.Quality > 0)
            {
                Item.Quality--;
            }

            Item.SellIn--;

            if (Item.SellIn < 0 && Item.Quality > 0)
            {
                Item.Quality--;
            }
        }
    }
}
