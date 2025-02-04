using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GildedRoseKata;
using Xunit;

namespace GildedRoseTests
{
    public class AgedBrieTest
    {
       [Fact]
       public void UpdateQualityWhenQualityLessThen50()
       {
            // Arrange
            Item Item = new Item { Name = "foo", SellIn = 0, Quality = 0 };
            BaseItem app = new AgedBrie(Item);
            // Act
            app.UpdateQuality();
            // Assert
            Assert.Equal(Item.Quality, 1);

        }
       [Fact]
        public void UpdateQualityWhenQualityMoreThen50()
        {
            Item Item = new Item { Name = "foo", SellIn = 0, Quality = 0 };
            BaseItem app = new AgedBrie(Item);
            // Act
            app.UpdateQuality();
            // Assert
            Assert.Equal(Item.Quality, 0);

        }
        [Fact]
        public void UpdateQualityWhenQualitylessThen50AndSellInNegative()
        {
            Item Item = new Item { Name = "foo", SellIn = 0, Quality = 0 };
            BaseItem app = new AgedBrie(Item);
            // Act
            app.UpdateQuality();
            // Assert
            Assert.Equal(Item.Quality, 1);

        }
    }
}
