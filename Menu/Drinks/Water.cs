/*  Water.cs
*   Author: Andrew Booze
*/

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A drink class that represents a cup of water.
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// An enum variable which stores the size of this drink.
        /// </summary>
        public override Size Size { get; set; }

        /// <summary>
        /// A list of ingredients for this drink.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string> { "Water" };
                if (Lemon)
                {
                    ingredients.Add("Lemon");
                }

                return ingredients;
            }
        }

        /// <summary>
        /// Whether or not this water has lemon. Defaults to false.
        /// </summary>
        public bool Lemon { get; private set; } = false;

        /// <summary>
        /// The constructor for the Water drink.
        /// </summary>
        public Water()
        {
            Price = 0.1;
            Calories = 0;
        }

        /// <summary>
        /// Allows the user to add lemon to the water.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
        }
    }
}
