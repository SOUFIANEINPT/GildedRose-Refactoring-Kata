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
       public void UpdateQualityWhenQualityLessThen50AndSellInIsPostive()
       {
            // Arrange
            Item Item = new Item { Name = "foo", SellIn = 1, Quality = 0 };
            BaseItem app = new AgedBrie(Item);
            // Act
            app.UpdateQuality();
            // Assert
            Assert.Equal(Item.Quality, 1);

        }
        [Fact]
        public void UpdateQualityWhenQualityLessThen50AndSellInIsNegative()
        {
            // Arrange
            Item Item = new Item { Name = "foo", SellIn = 0, Quality = 0 };
            BaseItem app = new AgedBrie(Item);
            // Act
            app.UpdateQuality();
            // Assert
            Assert.Equal(Item.Quality, 2);

        }
        [Fact]
        public void UpdateQualityWhenQualityMoreThen50()
        {
            Item Item = new Item { Name = "foo", SellIn = 0, Quality = 51 };
            BaseItem app = new AgedBrie(Item);
            // Act
            app.UpdateQuality();
            // Assert
            Assert.Equal(Item.Quality, 51);

        }
    }
}
