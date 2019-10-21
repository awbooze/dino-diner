using DinoDiner.Menu;
using System.Collections.Generic;
using Xunit;

namespace MenuTest.Entrees
{
    public class VelociWrapUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal(6.86, vw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal<uint>(356, vw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap vw = new VelociWrap();
            List<string> ingredients = vw.Ingredients;
            Assert.Contains<string>("Flour Tortilla", ingredients);
            Assert.Contains<string>("Chicken Breast", ingredients);
            Assert.Contains<string>("Romaine Lettuce", ingredients);
            Assert.Contains<string>("Ceasar Dressing", ingredients);
            Assert.Contains<string>("Parmesan Cheese", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.DoesNotContain<string>("Dressing", vw.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", vw.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.DoesNotContain<string>("Parmesan Cheese", vw.Ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectDescription()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal("Veloci-Wrap", vw.Description);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Empty(vw.Special);
        }

        [Fact]
        public void HoldDressingAddsHoldDressingToSpecial()
        {
            VelociWrap entree = new VelociWrap();
            entree.HoldDressing();
            Assert.Equal("Hold Dressing", entree.Special[0]);
        }

        [Fact]
        public void HoldLettuceAddsHoldLettuceToSpecial()
        {
            VelociWrap entree = new VelociWrap();
            entree.HoldLettuce();
            Assert.Equal("Hold Lettuce", entree.Special[0]);
        }

        [Fact]
        public void HoldCheeseAddsHoldCheeseToSpecial()
        {
            VelociWrap entree = new VelociWrap();
            entree.HoldCheese();
            Assert.Equal("Hold Cheese", entree.Special[0]);
        }

        [Fact]
        public void AddAllSpecialsToSpecial()
        {
            VelociWrap entree = new VelociWrap();
            entree.HoldDressing();
            entree.HoldLettuce();
            entree.HoldCheese();
            Assert.Equal("Hold Dressing", entree.Special[0]);
            Assert.Equal("Hold Lettuce", entree.Special[1]);
            Assert.Equal("Hold Cheese", entree.Special[2]);
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Ingredients")]
        public void HoldingIngredientsShouldNotifyOfPropertyChange(string propertyName)
        {
            VelociWrap entree = new VelociWrap();
            Assert.PropertyChanged(entree, propertyName, () =>
            {
                entree.HoldDressing();
            });
            Assert.PropertyChanged(entree, propertyName, () =>
            {
                entree.HoldLettuce();
            });
            Assert.PropertyChanged(entree, propertyName, () =>
            {
                entree.HoldCheese();
            });
        }
    }
}
