using DinoDiner.Menu;
using System.Collections.Generic;
using Xunit;

namespace MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal("Brontowurst", bw.Description);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Empty(bw.Special);
        }

        [Fact]
        public void HoldBunAddsHoldBunToSpecial()
        {
            Brontowurst entree = new Brontowurst();
            entree.HoldBun();
            Assert.Equal("Hold Bun", entree.Special[0]);
        }

        [Fact]
        public void HoldPeppersAddsHoldPeppersToSpecial()
        {
            Brontowurst entree = new Brontowurst();
            entree.HoldPeppers();
            Assert.Equal("Hold Peppers", entree.Special[0]);
        }

        [Fact]
        public void HoldOnionAddsHoldOnionToSpecial()
        {
            Brontowurst entree = new Brontowurst();
            entree.HoldOnion();
            Assert.Equal("Hold Onion", entree.Special[0]);
        }

        [Fact]
        public void AddAllSpecialsToSpecial()
        {
            Brontowurst entree = new Brontowurst();
            entree.HoldBun();
            entree.HoldPeppers();
            entree.HoldOnion();
            Assert.Equal("Hold Bun", entree.Special[0]);
            Assert.Equal("Hold Peppers", entree.Special[1]);
            Assert.Equal("Hold Onion", entree.Special[2]);
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Ingredients")]
        public void HoldingIngredientsShouldNotifyOfPropertyChange(string propertyName)
        {
            Brontowurst entree = new Brontowurst();
            Assert.PropertyChanged(entree, propertyName, () =>
            {
                entree.HoldBun();
            });
            Assert.PropertyChanged(entree, propertyName, () =>
            {
                entree.HoldOnion();
            });
            Assert.PropertyChanged(entree, propertyName, () =>
            {
                entree.HoldPeppers();
            });
        }
    }
}
