﻿/*  SteakosaurusBurger.cs
*   Author: Andrew Booze
*/

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// A class that represents a Steakosaurus Burger entree.
    /// </summary>
    public class SteakosaurusBurger
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
        /// The price of this entree.
        /// </summary>
        public double Price { get; set; }
        
        /// <summary>
        /// The number of calories in this entree.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// The list of ingredients for this entree.
        /// </summary>
        public List<string> Ingredients
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
            this.Price = 5.15;
            this.Calories = 621;
        }

        /// <summary>
        /// Allows the user to remove the bun from this entree.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }

        /// <summary>
        /// Allows the user to remove the pickle from this entree.
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }

        /// <summary>
        /// Allows the user to remove the ketchup from this entree.
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }

        /// <summary>
        /// Allows the user to remove the mustard from this entree.
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}