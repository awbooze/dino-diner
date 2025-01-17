﻿/*  DinoNuggets.cs
*   Author: Andrew Booze
*/

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represents an entree of Dino Nuggets.
    /// </summary>
    public class DinoNuggets : Entree
    {
        private uint numberOfNuggets;

        /// <summary>
        /// The list of ingredients for the dino nuggets.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { };
                for (int i = 0; i < numberOfNuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }

                return ingredients;
            }
        }

        /// <summary>
        /// The constructor for this entree. Sets the price and the calories.
        /// </summary>
        public DinoNuggets()
        {
            numberOfNuggets = 6;
            Price = 4.25;
            Calories = 59 * numberOfNuggets;
        }

        /// <summary>
        /// Function that allows the user to add a nugget for an additional cost.
        /// </summary>
        public void AddNugget()
        {
            numberOfNuggets++;
            Price += 0.25;
            Calories += 59;

            if (special.Count > 0)
            {
                special.RemoveAt(0);
            }

            if (numberOfNuggets == 7)
            {
                special.Add("1 Extra Nuggets");
            }
            else if (numberOfNuggets > 7)
            {
                special.Add($"{numberOfNuggets - 6} Extra Nuggets");
            }

            // Notify that properties have changed
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Ingredients");
        }

        /// <summary>
        /// Creates and returns a string representation of this object.
        /// </summary>
        /// <returns>A string representation of this object.</returns>
        public override string ToString()
        {
            return "Dino Nuggets";
        }
    }
}
