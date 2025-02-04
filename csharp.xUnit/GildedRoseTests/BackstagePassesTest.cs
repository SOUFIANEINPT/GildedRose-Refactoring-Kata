using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRoseKata;
using Xunit;

namespace GildedRoseTests
{
    public class BackstagePassesTest
    {
        [Fact]
        public void UpdateQualityWhenQualityLessThen50AnddSellInMoreThenTeen()
        {
            Item Item = new Item { Name = "foo", SellIn = 60, Quality = 0 };
            BaseItem app = new BackstagePasses(Item);
            // Act
            app.UpdateQuality();
            // Assert
            Assert.Equal(Item.Quality, 1);

        }
        [Fact]
        public void UpdateQualityWhenQualityLessThen50AndSellInLessThen10AndMoreThen5()
        {
            Item Item = new Item { Name = "foo", SellIn = 6, Quality = 0 };
            BaseItem app = new BackstagePasses(Item);
            // Act
            app.UpdateQuality();
            // Assert
            Assert.Equal(Item.Quality, 2);

        }
        [Fact]
        public void UpdateQualityWhenQualityLessThen50AndSellInLessThen5AndMoreThenZero()
        {
            Item Item = new Item { Name = "foo", SellIn = 4, Quality = 0 };
            BaseItem app = new BackstagePasses(Item);
            // Act
            app.UpdateQuality();
            // Assert
            Assert.Equal(Item.Quality, 3);

        }
        [Fact]
        public void UpdateQualityWhenQualityMoreThen50()
        {
            Item Item = new Item { Name = "foo", SellIn = 0, Quality = 0 };
            BaseItem app = new BackstagePasses(Item);
            // Act
            app.UpdateQuality();
            // Assert
            Assert.Equal(Item.Quality, 0);

        }
        [Fact]
        public void UpdateQualityWhenSellInNegative()
        {
            Item Item = new Item { Name = "foo", SellIn = 0, Quality = 0 };
            BaseItem app = new BackstagePasses(Item);
            // Act
            app.UpdateQuality();
            // Assert
            Assert.Equal(Item.Quality, 0);

        }
    }
}
