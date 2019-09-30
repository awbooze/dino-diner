/*  JurassicJavaTest.cs
*   Author: Andrew Booze
*/

using DinoDiner.Menu.Drinks;
using System.Collections.Generic;
using Xunit;

namespace MenuTest.Drinks
{
    /// <summary>
    /// Unit tests for JurassicJava drinks.
    /// </summary>
    public class JurassicJavaTest
    {
        /// <summary>
        /// Tests whether the drink has the correct default calories
        /// </summary>
        [Fact]
        public void HasCorrectDefaultCalories()
        {
            JurassicJava drink = new JurassicJava();
            Assert.Equal<uint>(2, drink.Calories);
        }

        /// <summary>
        /// Tests whether the drink has the correct default price
        /// </summary>
        [Fact]
        public void HasCorrectDefaultPrice()
        {
            JurassicJava drink = new JurassicJava();
            Assert.Equal<double>(0.59, drink.Price);
        }

        /// <summary>
        /// Tests whether the drink has the correct default ice
        /// </summary>
        [Fact]
        public void HasCorrectDefaultIce()
        {
            JurassicJava drink = new JurassicJava();
            Assert.False(drink.Ice);
        }

        /// <summary>
        /// Tests whether the drink has the correct default size
        /// </summary>
        [Fact]
        public void HasCorrectDefaultSize()
        {
            JurassicJava drink = new JurassicJava();
            Assert.Equal<Size>(Size.Small, drink.Size);
        }

        /// <summary>
        /// Tests whether the drink has the correct default room for cream
        /// </summary>
        [Fact]
        public void HasCorrectDefaultRoomForCream()
        {
            JurassicJava drink = new JurassicJava();
            Assert.False(drink.RoomForCream);
        }

        /// <summary>
        /// Tests whether the drink has the correct default calories after setting the small size
        /// </summary>
        [Fact]
        public void CorrectCaloriesAfterSettingSmall()
        {
            JurassicJava drink = new JurassicJava
            {
                Size = Size.Medium
            };
            drink.Size = Size.Small;
            Assert.Equal<uint>(2, drink.Calories);
        }

        /// <summary>
        /// Tests whether the drink has the correct default price after setting the small size
        /// </summary>
        [Fact]
        public void CorrectPriceAfterSettingSmall()
        {
            JurassicJava drink = new JurassicJava
            {
                Size = Size.Medium
            };
            drink.Size = Size.Small;
            Assert.Equal<double>(0.59, drink.Price);
        }

        /// <summary>
        /// Tests whether the drink has the correct default calories after setting the medium size
        /// </summary>
        [Fact]
        public void CorrectCaloriesAfterSettingMedium()
        {
            JurassicJava drink = new JurassicJava
            {
                Size = Size.Medium
            };
            Assert.Equal<uint>(4, drink.Calories);
        }

        /// <summary>
        /// Tests whether the drink has the correct default price after setting the medium size
        /// </summary>
        [Fact]
        public void CorrectPriceAfterSettingMedium()
        {
            JurassicJava drink = new JurassicJava
            {
                Size = Size.Medium
            };
            Assert.Equal<double>(0.99, drink.Price);
        }

        /// <summary>
        /// Tests whether the drink has the correct default calories after setting the large size
        /// </summary>
        [Fact]
        public void CorrectCaloriesAfterSettingLarge()
        {
            JurassicJava drink = new JurassicJava
            {
                Size = Size.Large
            };
            Assert.Equal<uint>(8, drink.Calories);
        }

        /// <summary>
        /// Tests whether the drink has the correct default price after setting the large size
        /// </summary>
        [Fact]
        public void CorrectPriceAfterSettingLarge()
        {
            JurassicJava drink = new JurassicJava
            {
                Size = Size.Large
            };
            Assert.Equal<double>(1.49, drink.Price);
        }

        /// <summary>
        /// Tests if the coffee has ice after AddIce is called
        /// </summary>
        [Fact]
        public void AddIceSetsIceToTrue()
        {
            JurassicJava drink = new JurassicJava();
            drink.AddIce();
            Assert.True(drink.Ice);
        }

        /// <summary>
        /// Tests if the coffee has room for cream after LeaveRoomForCream is called
        /// </summary>
        [Fact]
        public void LeaveRoomForCreamAddsRoomForCream()
        {
            JurassicJava drink = new JurassicJava();
            drink.LeaveRoomForCream();
            Assert.True(drink.RoomForCream);
        }

        /// <summary>
        /// Tests whether the drink has the correct default ingredients
        /// </summary>
        [Fact]
        public void ShouldListCorrectDefaultIngredients()
        {
            JurassicJava drink = new JurassicJava();
            List<string> ingredients = drink.Ingredients;
            Assert.Contains<string>("Water", ingredients);
            Assert.Contains<string>("Coffee", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }
    }
}
