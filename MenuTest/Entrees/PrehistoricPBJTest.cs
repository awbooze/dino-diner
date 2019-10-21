using DinoDiner.Menu;
using System.Collections.Generic;
using Xunit;

namespace MenuTest.Entrees
{
    public class PrehistoricPBJUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal(6.52, pbj.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal<uint>(483, pbj.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            List<string> ingredients = pbj.Ingredients;
            Assert.Contains<string>("Bread", ingredients);
            Assert.Contains<string>("Peanut Butter", ingredients);
            Assert.Contains<string>("Jelly", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }

        [Fact]
        public void HoldPeanutButterShouldRemovePeanutButter()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            Assert.DoesNotContain<string>("Peanut Butter", pbj.Ingredients);
        }

        [Fact]
        public void HoldJellyShouldRemoveJelly()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            Assert.DoesNotContain<string>("Jelly", pbj.Ingredients);
        }

        [Fact] 
        public void ShouldHaveCorrectDescription()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal("Prehistoric PB&J", pbj.Description);
        }

        [Fact]
        public void ShouldHaveEmptySpecialByDefault()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Empty(pbj.Special);
        }

        [Fact]
        public void HoldPeanutButterAddsHoldPeanutButterToSpecial()
        {
            PrehistoricPBJ entree = new PrehistoricPBJ();
            entree.HoldPeanutButter();
            Assert.Equal("Hold Peanut Butter", entree.Special[0]);
        }

        [Fact]
        public void HoldPeppersAddsHoldPeppersToSpecial()
        {
            PrehistoricPBJ entree = new PrehistoricPBJ();
            entree.HoldJelly();
            Assert.Equal("Hold Jelly", entree.Special[0]);
        }

        [Fact]
        public void AddAllSpecialsToSpecial()
        {
            PrehistoricPBJ entree = new PrehistoricPBJ();
            entree.HoldPeanutButter();
            entree.HoldJelly();
            Assert.Equal("Hold Peanut Butter", entree.Special[0]);
            Assert.Equal("Hold Jelly", entree.Special[1]);
        }

        [Theory]
        [InlineData("Special")]
        [InlineData("Ingredients")]
        public void HoldingIngredientsShouldNotifyOfPropertyChange(string propertyName)
        {
            PrehistoricPBJ entree = new PrehistoricPBJ();
            Assert.PropertyChanged(entree, propertyName, () =>
            {
                entree.HoldPeanutButter();
            });
            Assert.PropertyChanged(entree, propertyName, () =>
            {
                entree.HoldJelly();
            });
        }
    }
}
