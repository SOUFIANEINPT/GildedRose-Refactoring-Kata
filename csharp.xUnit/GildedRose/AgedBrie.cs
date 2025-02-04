using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class AgedBrie: BaseItem
    {
    public AgedBrie(Item item) : base(item) { }

        public override void UpdateQuality()
        {
            if (Item.Quality < 50)
            {
                Item.Quality++;
            }

            Item.SellIn--;

            if (Item.SellIn < 0 && Item.Quality < 50)
            {
                Item.Quality++;
            }
        }
    }
}
