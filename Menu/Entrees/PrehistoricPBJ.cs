﻿/*  PrehistoricPBJ.cs
*   Modified by: Andrew Booze
*/

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// An entree class for the Prehistoric PB and J.
    /// </summary>
    public class PrehistoricPBJ : Entree
    {
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// The list of ingrediants for this PB and J.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// The constructor for this entree. Sets the price and the calories.
        /// </summary>
        public PrehistoricPBJ()
        {
            Price = 6.52;
            Calories = 483;
        }

        /// <summary>
        /// Allows the user to remove the peanut butter from this PB and J.
        /// </summary>
        public void HoldPeanutButter()
        {
            if (peanutButter)
            {
                peanutButter = false;
                special.Add("Hold Peanut Butter");
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Allows the user to remove the jelly from this PB and J.
        /// </summary>
        public void HoldJelly()
        {
            if (jelly)
            {
                jelly = false;
                special.Add("Hold Jelly");
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
            return "Prehistoric PB&J";
        }
    }
}
