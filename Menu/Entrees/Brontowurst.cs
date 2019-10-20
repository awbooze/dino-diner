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
        private bool onion = true;

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
                if (onion) ingredients.Add("Onion");
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
            if (bun)
            {
                bun = false;
                special.Add("Hold Bun");
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Allows the user to remove the peppers from this entree.
        /// </summary>
        public void HoldPeppers()
        {
            if (peppers)
            {
                peppers = false;
                special.Add("Hold Peppers");
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Allows the user to remove the onions from this entree.
        /// </summary>
        public void HoldOnion()
        {
            if (onion)
            {
                onion = false;
                special.Add("Hold Onion");
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Creates and returns a string representation of this object.
        /// </summary>
        /// <returns>A string representation of this object.</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }
    }
}
