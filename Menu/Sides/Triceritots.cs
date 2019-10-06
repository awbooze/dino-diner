/*  Triceritots.cs
*   Author: Andrew Booze
*/

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class which represents a side of Triceritots.
    /// </summary>
    public class Triceritots : Side
    {
        private Size size;

        /// <summary>
        /// A variable storing the size of the entree.
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
                        Calories = 352;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 410;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 590;
                        break;
                }
            }
        }

        /// <summary>
        /// The list of ingrediants for the Triceritots.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Potato", "Salt", "Vegetable Oil" };
                return ingredients;
            }
        }

        /// <summary>
        /// The constructor for the Triceritots side. Sets the calories and price to the values for the small side.
        /// </summary>
        public Triceritots()
        {
            Calories = 352;
            Price = 0.99;
        }

        /// <summary>
        /// Creates and returns a string representation of this object.
        /// </summary>
        /// <returns>A string representation of this object.</returns>
        public override string ToString()
        {
            return Size.ToString() + " Triceritots";
        }
    }
}
