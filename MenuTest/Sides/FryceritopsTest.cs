﻿using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Sides
{
    public class FryceritopsTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Equal(0.99, ft.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Equal<uint>(222, ft.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Contains<string>("Potato", ft.Ingredients);
            Assert.Contains<string>("Salt", ft.Ingredients);
            Assert.Contains<string>("Vegetable Oil", ft.Ingredients);
            Assert.Equal<int>(3, ft.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Equal<Size>(Size.Small, ft.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal(1.45, ft.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal<uint>(365, ft.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, ft.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal(1.95, ft.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal<uint>(480, ft.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            Fryceritops ft = new Fryceritops();
            ft.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, ft.Size);
        }

        [Theory]
        [InlineData(Size.Small)]
        [InlineData(Size.Medium)]
        [InlineData(Size.Large)]
        public void DescriptionShouldGiveNameForSize(Size size)
        {
            Fryceritops ft = new Fryceritops
            {
                Size = size
            };
            Assert.Equal($"{size} Fryceritops", ft.Description);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            Fryceritops ft = new Fryceritops();
            Assert.Empty(ft.Special);
        }

        [Theory]
        [InlineData("Size")]
        [InlineData("Price")]
        [InlineData("Calories")]
        [InlineData("Description")]
        public void ChangingSizeShouldNotifyOfPropertyChange(string propertyName)
        {
            Fryceritops side = new Fryceritops();
            Assert.PropertyChanged(side, propertyName, () =>
            {
                side.Size = Size.Medium;
            });
            Assert.PropertyChanged(side, propertyName, () =>
            {
                side.Size = Size.Large;
            });
            Assert.PropertyChanged(side, propertyName, () =>
            {
                side.Size = Size.Small;
            });
        }
    }
}
