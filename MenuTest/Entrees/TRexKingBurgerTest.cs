using DinoDiner.Menu;
using System.Collections.Generic;
using Xunit;

namespace MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach (string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal("T-Rex King Burger", trex.Description);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Empty(trex.Special);
        }

        [Fact]
        public void HoldBunAddsHoldBunToSpecial()
        {
            TRexKingBurger entree = new TRexKingBurger();
            entree.HoldBun();
            Assert.Equal("Hold Bun", entree.Special[0]);
        }

        [Fact]
        public void HoldLettuceAddsHoldLettuceToSpecial()
        {
            TRexKingBurger entree = new TRexKingBurger();
            entree.HoldLettuce();
            Assert.Equal("Hold Lettuce", entree.Special[0]);
        }

        [Fact]
        public void HoldTomatoAddsHoldTomatoToSpecial()
        {
            TRexKingBurger entree = new TRexKingBurger();
            entree.HoldTomato();
            Assert.Equal("Hold Tomato", entree.Special[0]);
        }

        [Fact]
        public void HoldOnionAddsHoldOnionToSpecial()
        {
            TRexKingBurger entree = new TRexKingBurger();
            entree.HoldOnion();
            Assert.Equal("Hold Onion", entree.Special[0]);
        }

        [Fact]
        public void HoldPickleAddsHoldPickleToSpecial()
        {
            TRexKingBurger entree = new TRexKingBurger();
            entree.HoldPickle();
            Assert.Equal("Hold Pickle", entree.Special[0]);
        }

        [Fact]
        public void HoldKetchupAddsHoldKetchupToSpecial()
        {
            TRexKingBurger entree = new TRexKingBurger();
            entree.HoldKetchup();
            Assert.Equal("Hold Ketchup", entree.Special[0]);
        }

        [Fact]
        public void HoldMustardAddsHoldMustardToSpecial()
        {
            TRexKingBurger entree = new TRexKingBurger();
            entree.HoldMustard();
            Assert.Equal("Hold Mustard", entree.Special[0]);
        }

        [Fact]
        public void HoldMayoAddsHoldMayoToSpecial()
        {
            TRexKingBurger entree = new TRexKingBurger();
            entree.HoldMayo();
            Assert.Equal("Hold Mayo", entree.Special[0]);
        }

        [Fact]
        public void HoldBunAndLettuceAddsHoldBunAndHoldLettuceToSpecial()
        {
            TRexKingBurger entree = new TRexKingBurger();
            entree.HoldBun();
            entree.HoldLettuce();
            Assert.Equal("Hold Bun", entree.Special[0]);
            Assert.Equal("Hold Lettuce", entree.Special[1]);
        }

        [Fact]
        public void HoldTomatoAndOnionAddsHoldTomatoAndHoldOnionToSpecial()
        {
            TRexKingBurger entree = new TRexKingBurger();
            entree.HoldTomato();
            entree.HoldOnion();
            Assert.Equal("Hold Tomato", entree.Special[0]);
            Assert.Equal("Hold Onion", entree.Special[1]);
        }

        [Fact]
        public void HoldPickleAndKetchupAddsHoldPickleAndHoldKetchupToSpecial()
        {
            TRexKingBurger entree = new TRexKingBurger();
            entree.HoldPickle();
            entree.HoldKetchup();
            Assert.Equal("Hold Pickle", entree.Special[0]);
            Assert.Equal("Hold Ketchup", entree.Special[1]);
        }

        [Fact]
        public void HoldMustardAndMayoAddsHoldMustardAndHoldMayoToSpecial()
        {
            TRexKingBurger entree = new TRexKingBurger();
            entree.HoldMustard();
            entree.HoldMayo();
            Assert.Equal("Hold Mustard", entree.Special[0]);
            Assert.Equal("Hold Mayo", entree.Special[1]);
        }

        [Fact]
        public void HoldBunLettuceAndMayoAddsHoldBunHoldLettuceAndHoldMayoToSpecial()
        {
            TRexKingBurger entree = new TRexKingBurger();
            entree.HoldBun();
            entree.HoldLettuce();
            entree.HoldMayo();
            Assert.Equal("Hold Bun", entree.Special[0]);
            Assert.Equal("Hold Lettuce", entree.Special[1]);
            Assert.Equal("Hold Mayo", entree.Special[2]);
        }

        [Fact]
        public void HoldKetchupMustardAndMayoAddsHoldKetchupHoldMustardAndHoldMayoToSpecial()
        {
            TRexKingBurger entree = new TRexKingBurger();
            entree.HoldKetchup();
            entree.HoldMustard();
            entree.HoldMayo();
            Assert.Equal("Hold Ketchup", entree.Special[0]);
            Assert.Equal("Hold Mustard", entree.Special[1]);
            Assert.Equal("Hold Mayo", entree.Special[2]);
        }

        [Fact]
        public void AddAllSpecialsToSpecial()
        {
            TRexKingBurger entree = new TRexKingBurger();
            entree.HoldBun();
            entree.HoldLettuce();
            entree.HoldTomato();
            entree.HoldOnion();
            entree.HoldPickle();
            entree.HoldKetchup();
            entree.HoldMustard();
            entree.HoldMayo();
            Assert.Equal("Hold Bun", entree.Special[0]);
            Assert.Equal("Hold Lettuce", entree.Special[1]);
            Assert.Equal("Hold Tomato", entree.Special[2]);
            Assert.Equal("Hold Onion", entree.Special[3]);
            Assert.Equal("Hold Pickle", entree.Special[4]);
            Assert.Equal("Hold Ketchup", entree.Special[5]);
            Assert.Equal("Hold Mustard", entree.Special[6]);
            Assert.Equal("Hold Mayo", entree.Special[7]);
        }
    }
}
