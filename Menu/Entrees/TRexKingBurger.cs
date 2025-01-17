﻿/*  TRexKingBurger.cs
*   Author: Andrew Booze
*/

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represents a T-Rex King Burger entree.
    /// </summary>
    public class TRexKingBurger : Entree
    {
        /// <summary>
        /// Whether or not the bun is included in this entree.
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// Whether or not the lettuce is included in this entree.
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// Whether or not the tomato is included in this entree.
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// Whether or not the onion is included in this entree.
        /// </summary>
        private bool onion = true;

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
        /// Whether or not the mayo is included in this entree.
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// The list of ingredients for this entree.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Steakburger Pattie", "Steakburger Pattie", "Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }

        /// <summary>
        /// The constructor for this entree. Sets the price and the calories.
        /// </summary>
        public TRexKingBurger()
        {
            Price = 8.45;
            Calories = 728;
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
        /// Allows the user to remove the lettuce from this entree.
        /// </summary>
        public void HoldLettuce()
        {
            if (lettuce)
            {
                lettuce = false;
                special.Add("Hold Lettuce");
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Allows the user to remove the tomato from this entree.
        /// </summary>
        public void HoldTomato()
        {
            if (tomato)
            {
                tomato = false;
                special.Add("Hold Tomato");
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Allows the user to remove the onion from this entree.
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
        /// Allows the user to remove the mayo from this entree.
        /// </summary>
        public void HoldMayo()
        {
            if (mayo)
            {
                mayo = false;
                special.Add("Hold Mayo");
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
            return "T-Rex King Burger";
        }
    }
}
