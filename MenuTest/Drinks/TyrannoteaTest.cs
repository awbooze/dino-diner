/*  TyrannoteaTest.cs
*   Author: Andrew Booze
*/

using DinoDiner.Menu;
using System.Collections.Generic;
using Xunit;

namespace MenuTest.Drinks
{
    /// <summary>
    /// Unit tests for Tyrannotea drinks.
    /// </summary>
    public class TyrannoteaTest
    {
        /// <summary>
        /// Tests whether the drink has the correct default calories
        /// </summary>
        [Fact]
        public void HasCorrectDefaultCalories()
        {
            Tyrannotea drink = new Tyrannotea();
            Assert.Equal<uint>(8, drink.Calories);
        }

        /// <summary>
        /// Tests whether the drink has the correct default price
        /// </summary>
        [Fact]
        public void HasCorrectDefaultPrice()
        {
            Tyrannotea drink = new Tyrannotea();
            Assert.Equal<double>(0.99, drink.Price);
        }

        /// <summary>
        /// Tests whether the drink has the correct default ice
        /// </summary>
        [Fact]
        public void HasCorrectDefaultIce()
        {
            Tyrannotea drink = new Tyrannotea();
            Assert.True(drink.Ice);
        }

        /// <summary>
        /// Tests whether the drink has the correct default size
        /// </summary>
        [Fact]
        public void HasCorrectDefaultSize()
        {
            Tyrannotea drink = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, drink.Size);
        }

        /// <summary>
        /// Tests whether the drink has the correct default sweetness
        /// </summary>
        [Fact]
        public void HasCorrectDefaultSweetness()
        {
            Tyrannotea drink = new Tyrannotea();
            Assert.False(drink.Sweet);
        }

        /// <summary>
        /// Tests whether the drink has the correct default lemon
        /// </summary>
        [Fact]
        public void HasCorrectDefaultLemon()
        {
            Tyrannotea drink = new Tyrannotea();
            Assert.False(drink.Lemon);
        }

        /// <summary>
        /// Tests whether the drink has the correct default calories after setting the small size
        /// </summary>
        [Fact]
        public void CorrectCaloriesAfterSettingSmall()
        {
            Tyrannotea drink = new Tyrannotea
            {
                Size = Size.Medium
            };
            drink.Size = Size.Small;
            Assert.Equal<uint>(8, drink.Calories);
        }

        /// <summary>
        /// Tests whether the drink has the correct default calories after setting the small size 
        /// and sweetening it
        /// </summary>
        [Fact]
        public void CorrectCaloriesAfterSettingSmallAndSweet()
        {
            Tyrannotea drink = new Tyrannotea
            {
                Size = Size.Medium
            };
            drink.Size = Size.Small;
            drink.MakeSweet();
            Assert.Equal<uint>(16, drink.Calories);
        }

        /// <summary>
        /// Tests whether the drink has the correct default price after setting the small size
        /// </summary>
        [Fact]
        public void CorrectPriceAfterSettingSmall()
        {
            Tyrannotea drink = new Tyrannotea
            {
                Size = Size.Medium
            };
            drink.Size = Size.Small;
            Assert.Equal<double>(0.99, drink.Price);
        }

        /// <summary>
        /// Tests whether the drink has the correct default calories after setting the medium size
        /// </summary>
        [Fact]
        public void CorrectCaloriesAfterSettingMedium()
        {
            Tyrannotea drink = new Tyrannotea
            {
                Size = Size.Medium
            };
            Assert.Equal<uint>(16, drink.Calories);
        }

        /// <summary>
        /// Tests whether the drink has the correct default calories after setting the medium size 
        /// and sweetening it
        /// </summary>
        [Fact]
        public void CorrectCaloriesAfterSettingMediumAndSweet()
        {
            Tyrannotea drink = new Tyrannotea
            {
                Size = Size.Medium
            };
            drink.MakeSweet();
            Assert.Equal<uint>(32, drink.Calories);
        }

        /// <summary>
        /// Tests whether the drink has the correct default price after setting the medium size
        /// </summary>
        [Fact]
        public void CorrectPriceAfterSettingMedium()
        {
            Tyrannotea drink = new Tyrannotea
            {
                Size = Size.Medium
            };
            Assert.Equal<double>(1.49, drink.Price);
        }

        /// <summary>
        /// Tests whether the drink has the correct default calories after setting the large size
        /// </summary>
        [Fact]
        public void CorrectCaloriesAfterSettingLarge()
        {
            Tyrannotea drink = new Tyrannotea
            {
                Size = Size.Large
            };
            Assert.Equal<uint>(32, drink.Calories);
        }

        /// <summary>
        /// Tests whether the drink has the correct default calories after setting the large size 
        /// and sweetening it
        /// </summary>
        [Fact]
        public void CorrectCaloriesAfterSettingLargeAndSweet()
        {
            Tyrannotea drink = new Tyrannotea
            {
                Size = Size.Large
            };
            drink.MakeSweet();
            Assert.Equal<uint>(64, drink.Calories);
        }

        /// <summary>
        /// Tests whether the drink has the correct default price after setting the large size
        /// </summary>
        [Fact]
        public void CorrectPriceAfterSettingLarge()
        {
            Tyrannotea drink = new Tyrannotea
            {
                Size = Size.Large
            };
            Assert.Equal<double>(1.99, drink.Price);
        }

        /// <summary>
        /// Tests if the drink has no ice after HoldIce is called
        /// </summary>
        [Fact]
        public void HoldIceSetsIceToFalse()
        {
            Tyrannotea drink = new Tyrannotea();
            drink.HoldIce();
            Assert.False(drink.Ice);
        }

        /// <summary>
        /// Tests if the drink has lemon after AddLemon is called
        /// </summary>
        [Fact]
        public void AddLemonAddsLemon()
        {
            Tyrannotea drink = new Tyrannotea();
            drink.AddLemon();
            Assert.True(drink.Lemon);
        }

        /// <summary>
        /// Tests whether the drink has the correct default ingredients
        /// </summary>
        [Fact]
        public void ShouldListCorrectDefaultIngredients()
        {
            Tyrannotea drink = new Tyrannotea();
            List<string> ingredients = drink.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Tea", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }

        // Because I created my properties with protected or private sets, it is impossible for the program 
        // to set the sweet property to false after it is set to true. Therefore, I do not need to test it 
        // for this milestone.
    }
}
