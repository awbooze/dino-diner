﻿/*  WaterTest.cs
*   Author: Andrew Booze
*/

using DinoDiner.Menu;
using DinoDiner.Menu.Drinks;
using System.Collections.Generic;
using Xunit;

namespace MenuTest.Drinks
{
    /// <summary>
    /// Unit tests for "Water" drinks.
    /// </summary>
    public class WaterTest
    {
        /// <summary>
        /// Tests whether the drink has the correct default calories
        /// </summary>
        [Fact]
        public void HasCorrectDefaultCalories()
        {
            Water drink = new Water();
            Assert.Equal<uint>(0, drink.Calories);
        }

        /// <summary>
        /// Tests whether the drink has the correct default price
        /// </summary>
        [Fact]
        public void HasCorrectDefaultPrice()
        {
            Water drink = new Water();
            Assert.Equal<double>(0.10, drink.Price);
        }

        /// <summary>
        /// Tests whether the drink has the correct default ice
        /// </summary>
        [Fact]
        public void HasCorrectDefaultIce()
        {
            Water drink = new Water();
            Assert.True(drink.Ice);
        }

        /// <summary>
        /// Tests whether the drink has the correct default size
        /// </summary>
        [Fact]
        public void HasCorrectDefaultSize()
        {
            Water drink = new Water();
            Assert.Equal<Size>(Size.Small, drink.Size);
        }

        /// <summary>
        /// Tests whether the drink has the correct default lemon
        /// </summary>
        [Fact]
        public void HasCorrectDefaultLemon()
        {
            Water drink = new Water();
            Assert.False(drink.Lemon);
        }

        /// <summary>
        /// Tests whether the drink has the correct default calories after setting the small size
        /// </summary>
        [Fact]
        public void CorrectCaloriesAfterSettingSmall()
        {
            Water drink = new Water
            {
                Size = Size.Medium
            };
            drink.Size = Size.Small;
            Assert.Equal<uint>(0, drink.Calories);
        }

        /// <summary>
        /// Tests whether the drink has the correct default price after setting the small size
        /// </summary>
        [Fact]
        public void CorrectPriceAfterSettingSmall()
        {
            Water drink = new Water
            {
                Size = Size.Medium
            };
            drink.Size = Size.Small;
            Assert.Equal<double>(0.10, drink.Price);
        }

        /// <summary>
        /// Tests whether the drink has the correct default calories after setting the medium size
        /// </summary>
        [Fact]
        public void CorrectCaloriesAfterSettingMedium()
        {
            Water drink = new Water
            {
                Size = Size.Medium
            };
            Assert.Equal<uint>(0, drink.Calories);
        }

        /// <summary>
        /// Tests whether the drink has the correct default price after setting the medium size
        /// </summary>
        [Fact]
        public void CorrectPriceAfterSettingMedium()
        {
            Water drink = new Water
            {
                Size = Size.Medium
            };
            Assert.Equal<double>(0.10, drink.Price);
        }

        /// <summary>
        /// Tests whether the drink has the correct default calories after setting the large size
        /// </summary>
        [Fact]
        public void CorrectCaloriesAfterSettingLarge()
        {
            Water drink = new Water
            {
                Size = Size.Large
            };
            Assert.Equal<uint>(0, drink.Calories);
        }

        /// <summary>
        /// Tests whether the drink has the correct default price after setting the large size
        /// </summary>
        [Fact]
        public void CorrectPriceAfterSettingLarge()
        {
            Water drink = new Water
            {
                Size = Size.Large
            };
            Assert.Equal<double>(0.10, drink.Price);
        }

        /// <summary>
        /// Tests if the drink has no ice after HoldIce is called
        /// </summary>
        [Fact]
        public void HoldIceSetsIceToFalse()
        {
            Water drink = new Water();
            drink.HoldIce();
            Assert.False(drink.Ice);
        }

        /// <summary>
        /// Tests if the drink has lemon after AddLemon is called
        /// </summary>
        [Fact]
        public void AddLemonAddsLemon()
        {
            Water drink = new Water();
            drink.AddLemon();
            Assert.True(drink.Lemon);
        }

        /// <summary>
        /// Tests whether the drink has the correct default ingredients
        /// </summary>
        [Fact]
        public void ShouldListCorrectDefaultIngredients()
        {
            Water drink = new Water();
            List<string> ingredients = drink.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Single<string>(ingredients);
        }
    }
}