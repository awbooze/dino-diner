/*  SodasaurusTest.cs
*   Author: Andrew Booze
*/

using DinoDiner.Menu;
using System.Collections.Generic;
using Xunit;

namespace MenuTest.Drinks
{
    /// <summary>
    /// Unit tests for Sodasaurus drinks.
    /// </summary>
    public class SodasaurusTest
    {
        /// <summary>
        /// Tests whether the program can select the Cola flavor
        /// </summary>
        [Fact]
        public void CanSelectColaFlavor()
        {
            Sodasaurus soda = new Sodasaurus
            {
                Flavor = SodasaurusFlavor.Vanilla
            };

            soda.Flavor = SodasaurusFlavor.Cola;

            Assert.Equal(SodasaurusFlavor.Cola, soda.Flavor);
        }

        /// <summary>
        /// Tests whether the program can select the Orange flavor
        /// </summary>
        [Fact]
        public void CanSelectOrangeFlavor()
        {
            Sodasaurus soda = new Sodasaurus
            {
                Flavor = SodasaurusFlavor.Orange
            };

            Assert.Equal(SodasaurusFlavor.Orange, soda.Flavor);
        }

        /// <summary>
        /// Tests whether the program can select the Vanilla flavor
        /// </summary>
        [Fact]
        public void CanSelectVanillaFlavor()
        {
            Sodasaurus soda = new Sodasaurus
            {
                Flavor = SodasaurusFlavor.Vanilla
            };

            Assert.Equal(SodasaurusFlavor.Vanilla, soda.Flavor);
        }

        /// <summary>
        /// Tests whether the program can select the Chocolate flavor
        /// </summary>
        [Fact]
        public void CanSelectChocolateFlavor()
        {
            Sodasaurus soda = new Sodasaurus
            {
                Flavor = SodasaurusFlavor.Chocolate
            };

            Assert.Equal(SodasaurusFlavor.Chocolate, soda.Flavor);
        }

        /// <summary>
        /// Tests whether the program can select the Root Beer flavor
        /// </summary>
        [Fact]
        public void CanSelectRootBeerFlavor()
        {
            Sodasaurus soda = new Sodasaurus
            {
                Flavor = SodasaurusFlavor.RootBeer
            };

            Assert.Equal(SodasaurusFlavor.RootBeer, soda.Flavor);
        }

        /// <summary>
        /// Tests whether the program can select the Cherry flavor
        /// </summary>
        [Fact]
        public void CanSelectCherryFlavor()
        {
            Sodasaurus soda = new Sodasaurus
            {
                Flavor = SodasaurusFlavor.Cherry
            };

            Assert.Equal(SodasaurusFlavor.Cherry, soda.Flavor);
        }

        /// <summary>
        /// Tests whether the program can select the Lime flavor
        /// </summary>
        [Fact]
        public void CanSelectLimeFlavor()
        {
            Sodasaurus soda = new Sodasaurus
            {
                Flavor = SodasaurusFlavor.Lime
            };

            Assert.Equal(SodasaurusFlavor.Lime, soda.Flavor);
        }

        /// <summary>
        /// Tests whether the program can select the Grape flavor
        /// </summary>
        [Fact]
        public void CanSelectGrapeFlavor()
        {
            Sodasaurus soda = new Sodasaurus
            {
                Flavor = SodasaurusFlavor.Grape
            };

            Assert.Equal(SodasaurusFlavor.Grape, soda.Flavor);
        }

        /// <summary>
        /// Tests whether the drink has the correct default calories
        /// </summary>
        [Fact]
        public void HasCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }

        /// <summary>
        /// Tests whether the drink has the correct default price
        /// </summary>
        [Fact]
        public void HasCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }

        /// <summary>
        /// Tests whether the drink has the correct default ice
        /// </summary>
        [Fact]
        public void HasCorrectDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

        /// <summary>
        /// Tests whether the drink has the correct default size
        /// </summary>
        [Fact]
        public void HasCorrectDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, soda.Size);
        }

        /// <summary>
        /// Tests whether the drink has the correct default calories after setting the small size
        /// </summary>
        [Fact]
        public void CorrectCaloriesAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus
            {
                Size = Size.Medium
            };

            soda.Size = Size.Small;
            Assert.Equal<uint>(112, soda.Calories);
        }

        /// <summary>
        /// Tests whether the drink has the correct default price after setting the small size
        /// </summary>
        [Fact]
        public void CorrectPriceAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus
            {
                Size = Size.Medium
            };

            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
        }

        /// <summary>
        /// Tests whether the drink has the correct default calories after setting the medium size
        /// </summary>
        [Fact]
        public void CorrectCaloriesAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus
            {
                Size = Size.Medium
            };

            Assert.Equal<uint>(156, soda.Calories);
        }

        /// <summary>
        /// Tests whether the drink has the correct default price after setting the medium size
        /// </summary>
        [Fact]
        public void CorrectPriceAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus
            {
                Size = Size.Medium
            };

            Assert.Equal<double>(2.00, soda.Price);
        }

        /// <summary>
        /// Tests whether the drink has the correct default calories after setting the large size
        /// </summary>
        [Fact]
        public void CorrectCaloriesAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus
            {
                Size = Size.Large
            };

            Assert.Equal<uint>(208, soda.Calories);
        }

        /// <summary>
        /// Tests whether the drink has the correct default price after setting the large size
        /// </summary>
        [Fact]
        public void CorrectPriceAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus
            {
                Size = Size.Large
            };

            Assert.Equal<double>(2.50, soda.Price);
        }

        /// <summary>
        /// Tests if the drink has no ice after HoldIce is called
        /// </summary>
        [Fact]
        public void HoldIceSetsIceToFalse()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }

        /// <summary>
        /// Tests whether the drink has the correct default ingredients
        /// </summary>
        [Fact]
        public void ShouldListCorrectDefaultIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            List<string> ingredients = soda.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Natural Flavors", ingredients);
            Assert.Contains<string>("Cane Sugar", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }

        [Theory]
        [InlineData(Size.Small, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Small, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Small, SodasaurusFlavor.Cola)]
        [InlineData(Size.Small, SodasaurusFlavor.Lime)]
        [InlineData(Size.Small, SodasaurusFlavor.Orange)]
        [InlineData(Size.Small, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Small, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Medium, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Medium, SodasaurusFlavor.Cola)]
        [InlineData(Size.Medium, SodasaurusFlavor.Lime)]
        [InlineData(Size.Medium, SodasaurusFlavor.Orange)]
        [InlineData(Size.Medium, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Medium, SodasaurusFlavor.Vanilla)]
        [InlineData(Size.Large, SodasaurusFlavor.Cherry)]
        [InlineData(Size.Large, SodasaurusFlavor.Chocolate)]
        [InlineData(Size.Large, SodasaurusFlavor.Cola)]
        [InlineData(Size.Large, SodasaurusFlavor.Lime)]
        [InlineData(Size.Large, SodasaurusFlavor.Orange)]
        [InlineData(Size.Large, SodasaurusFlavor.RootBeer)]
        [InlineData(Size.Large, SodasaurusFlavor.Vanilla)]
        public void DescriptionShouldGiveNameForSizeAndFlavor(Size size, SodasaurusFlavor flavor)
        {
            Sodasaurus drink = new Sodasaurus
            {
                Size = size,
                Flavor = flavor
            };
            Assert.Equal($"{size} {flavor} Sodasaurus", drink.Description);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            Sodasaurus drink = new Sodasaurus();
            Assert.Empty(drink.Special);
        }
    }
}
