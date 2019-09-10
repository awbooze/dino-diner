/*  DinoNuggets.cs
*   Author: Andrew Booze
*/

using System.Collections.Generic;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// A class that represents an entree of Dino Nuggets.
    /// </summary>
    public class DinoNuggets
    {
        private uint numberOfNuggets;

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
            this.numberOfNuggets = 6;
            this.Price = 4.25;
            this.Calories = 59 * numberOfNuggets;
        }

        public void AddNugget()
        {
            numberOfNuggets++;
            this.Price += 0.25;
            this.Calories += 59;
        }
    }
}
