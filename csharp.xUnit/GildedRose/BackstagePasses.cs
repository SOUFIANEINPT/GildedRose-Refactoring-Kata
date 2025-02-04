using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedRoseKata
{
    public class BackstagePasses : BaseItem
    {
        public BackstagePasses(Item item) : base(item) { }

        public override void UpdateQuality()
        {
            if (Item.Quality < 50)
            {
                Item.Quality++;
                if (Item.SellIn < 10) Item.Quality++;
                if (Item.SellIn < 5) Item.Quality++;
            }

            Item.SellIn--;

            if (Item.SellIn < 0)
            {
                Item.Quality = 0;
            }
        }
    }
}
