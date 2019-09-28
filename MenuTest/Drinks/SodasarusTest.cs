using DinoDiner.Menu.Drinks;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MenuTest.Drinks
{
    public class SodasarusTest
    {
        // The correct default calories
        [Fact]
        public void HasCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }

        // The correct default price
        [Fact]
        public void HasCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }

        // The correct default ice
        [Fact]
        public void HasCorrectDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

        // The correct default size

        // Correct calories after setting small
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

        // Correct price after setting small

        // Correct calories after setting medium
        // Correct price after setting medium

        // Correct calories after setting large
        // Correct price after setting large
    }
}
