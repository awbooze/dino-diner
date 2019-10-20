/*  SteakosaurusBurger.cs
*   Author: Andrew Booze
*/

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represents a Steakosaurus Burger entree.
    /// </summary>
    public class SteakosaurusBurger : Entree
    {
        /// <summary>
        /// Whether or not the bun is included in this entree.
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Whether or not the pickle is included in this entree.
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// Whether or not the ketchup is included in this entree.
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// Whether or not the mustard is included in this entree.
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// The list of ingredients for this entree.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// The constructor for this entree. Sets the price and the calories.
        /// </summary>
        public SteakosaurusBurger()
        {
            Price = 5.15;
            Calories = 621;
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
        /// Allows the user to remove the pickle from this entree.
        /// </summary>
        public void HoldPickle()
        {
            if (pickle)
            {
                pickle = false;
                special.Add("Hold Pickle");
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Allows the user to remove the ketchup from this entree.
        /// </summary>
        public void HoldKetchup()
        {
            if (ketchup)
            {
                ketchup = false;
                special.Add("Hold Ketchup");
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Allows the user to remove the mustard from this entree.
        /// </summary>
        public void HoldMustard()
        {
            if (mustard)
            {
                mustard = false;
                special.Add("Hold Mustard");
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
            return "Steakosaurus Burger";
        }
    }
}
