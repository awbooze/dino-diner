/*  Brontowurst.cs
*   Author: Andrew Booze
*/

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represents a Brontowurst entree.
    /// </summary>
    public class Brontowurst : Entree
    {
        /// <summary>
        /// Whether or not the bun is included in the brontowurst.
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Whether or not the peppers are included in the brontowurst.
        /// </summary>
        private bool peppers = true;

        /// <summary>
        /// Whether or not the onions are included in the brontowurst.
        /// </summary>
        private bool onions = true;

        /// <summary>
        /// The list of ingredients for the brontowurst.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Brautwurst" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (peppers) ingredients.Add("Peppers");
                if (onions) ingredients.Add("Onion");
                return ingredients;
            }
        }

        /// <summary>
        /// The constructor for the brontowurst. Sets the price and the calories.
        /// </summary>
        public Brontowurst()
        {
            Price = 5.36;
            Calories = 498;
        }

        /// <summary>
        /// Allows the user to remove the bun from this entree.
        /// </summary>
        public void HoldBun()
        {
            bun = false;
        }

        /// <summary>
        /// Allows the user to remove the peppers from this entree.
        /// </summary>
        public void HoldPeppers()
        {
            peppers = false;
        }

        /// <summary>
        /// Allows the user to remove the onions from this entree.
        /// </summary>
        public void HoldOnion()
        {
            onions = false;
        }
    }
}
