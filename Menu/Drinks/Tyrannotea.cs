/*  Tyrannotea.cs
*   Author: Andrew Booze
*/

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A drink class that represents a cup of tea.
    /// </summary>
    public class Tyrannotea : Drink
    {
        // Private backing variable
        private Size size;

        /// <summary>
        /// An enum variable which stores the size of this drink.
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;

                switch (value)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;
                }

                // Double calorie values if sweet
                if (Sweet)
                {
                    Calories *= 2;
                }

                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// A list of ingredients for this drink.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Water", "Tea" };
                if (Lemon)
                {
                    ingredients.Add("Lemon");
                }
                if (Sweet)
                {
                    ingredients.Add("Cane Sugar");
                }

                return ingredients;
            }
        }

        /// <summary>
        /// Whether or not this tea has lemon. Defaults to false.
        /// </summary>
        public bool Lemon { get; private set; } = false;

        /// <summary>
        /// Whether or not this tea is sweet. Defaults to false, although in other parts of the country 
        /// it would likely be better to default to true.
        /// </summary>
        public bool Sweet { get; set; } = false;

        /// <summary>
        /// The constructor for the Tyrannotea drink.
        /// </summary>
        public Tyrannotea()
        {
            Price = 0.99;
            Calories = 8;
        }

        /// <summary>
        /// Allows the user to add lemon to the tea.
        /// </summary>
        public void AddLemon()
        {
            if (!Lemon)
            {
                Lemon = true;
                special.Add("Add Lemon");
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Allows the user to make the tea sweet.
        /// </summary>
        public void MakeSweet()
        {
            if (!Sweet)
            {
                Sweet = true;

                // Double calorie values if sweet
                Calories *= 2;

                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Calories");
                NotifyOfPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Creates and returns a string representation of this object.
        /// </summary>
        /// <returns>A string representation of this object.</returns>
        public override string ToString()
        {
            string toReturn = Size.ToString();
            if (Sweet)
            {
                toReturn += " Sweet";
            }
            toReturn += " Tyrannotea";
            return toReturn;
        }
    }
}
