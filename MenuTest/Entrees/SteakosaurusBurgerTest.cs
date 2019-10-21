using DinoDiner.Menu;
using System.Collections.Generic;
using Xunit;

namespace MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", sb.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", sb.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", sb.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", sb.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal("Steakosaurus Burger", sb.Description);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Empty(sb.Special);
        }

        [Fact]
        public void HoldBunAddsHoldBunToSpecial()
        {
            SteakosaurusBurger entree = new SteakosaurusBurger();
            entree.HoldBun();
            Assert.Equal("Hold Bun", entree.Special[0]);
        }

        [Fact]
        public void HoldPickleAddsHoldPickleToSpecial()
        {
            SteakosaurusBurger entree = new SteakosaurusBurger();
            entree.HoldPickle();
            Assert.Equal("Hold Pickle", entree.Special[0]);
        }

        [Fact]
        public void HoldKetchupAddsHoldKetchupToSpecial()
        {
            SteakosaurusBurger entree = new SteakosaurusBurger();
            entree.HoldKetchup();
            Assert.Equal("Hold Ketchup", entree.Special[0]);
        }

        [Fact]
        public void HoldMustardAddsHoldMustardToSpecial()
        {
            SteakosaurusBurger entree = new SteakosaurusBurger();
            entree.HoldMustard();
            Assert.Equal("Hold Mustard", entree.Special[0]);
        }

        [Fact]
        public void HoldBunAndKetchupAddsHoldBunAndHoldKetchupToSpecial()
        {
            SteakosaurusBurger entree = new SteakosaurusBurger();
            entree.HoldBun();
            entree.HoldKetchup();
            Assert.Equal("Hold Bun", entree.Special[0]);
            Assert.Equal("Hold Ketchup", entree.Special[1]);
        }

        [Fact]
        public void HoldPickleAndMustardAddsHoldPickleAndHoldMustardToSpecial()
        {
            SteakosaurusBurger entree = new SteakosaurusBurger();
            entree.HoldPickle();
            entree.HoldMustard();
            Assert.Equal("Hold Pickle", entree.Special[0]);
            Assert.Equal("Hold Mustard", entree.Special[1]);
        }

        [Fact]
        public void AddAllSpecialsToSpecial()
        {
            SteakosaurusBurger entree = new SteakosaurusBurger();
            entree.HoldBun();
            entree.HoldPickle();
            entree.HoldKetchup();
            entree.HoldMustard();
            Assert.Equal("Hold Bun", entree.Special[0]);
            Assert.Equal("Hold Pickle", entree.Special[1]);
            Assert.Equal("Hold Ketchup", entree.Special[2]);
            Assert.Equal("Hold Mustard", entree.Special[3]);
        }
    }
}
