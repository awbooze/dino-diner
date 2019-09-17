/*  VelociWrap.cs
*   Author: Andrew Booze
*/

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// A class that represents a VelociWrap entree.
    /// </summary>
    public class VelociWrap : Entree
    {
        /// <summary>
        /// Whether or not the dressing is included in this entree.
        /// </summary>
        private bool dressing = true;

        /// <summary>
        /// Whether or not the lettuce is included in this entree.
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Whether or not the cheese is included in this entree.
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// The list of ingredients for this entree.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Flour Tortilla", "Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }

        /// <summary>
        /// The constructor for this entree. Sets the price and the calories.
        /// </summary>
        public VelociWrap()
        {
            Price = 6.86;
            Calories = 356;
        }

        /// <summary>
        /// Allows the user to remove the bun from this entree.
        /// </summary>
        public void HoldDressing()
        {
            dressing = false;
        }

        /// <summary>
        /// Allows the user to remove the peppers from this entree.
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
        }

        /// <summary>
        /// Allows the user to remove the onions from this entree.
        /// </summary>
        public void HoldCheese()
        {
            cheese = false;
        }
    }
}
