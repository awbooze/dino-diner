/*  MezzorellaSticks.cx
*   Author: Andrew Booze
*/

using System.Collections.Generic;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// A class which represents a side of Triceritots.
    /// </summary>
    public class MezzorellaSticks : Side
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
                        Calories = 540;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 610;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 720;
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
                List<string> ingredients = new List<string>() { "Breading", "Cheese Product", "Vegetable Oil" };
                return ingredients;
            }
        }

        /// <summary>
        /// The constructor for the Triceritots side. Sets the calories and price to the values for the small side.
        /// </summary>
        public MezzorellaSticks()
        {
            Calories = 540;
            Price = 0.99;
        }
    }
}
