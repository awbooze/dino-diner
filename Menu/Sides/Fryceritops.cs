/*  Fryceritops.cs
*   Author: Andrew Booze
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    /// <summary>
    /// A class which represents a side of Fryceritops.
    /// </summary>
    public class Fryceritops : Side
    {
        /// <summary>
        /// A variable storing the size of the entree.
        /// </summary>
        public override Size Size
        {
            get
            {
                return Size;
            }
            set
            {
                Size = value;

                switch (value)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 222;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 365;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 480;
                        break;
                }
            }
        }

        /// <summary>
        /// The list of ingrediants for the Fryceritops.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Potatoe", "Salt", "Vegtable Oil" };
                return ingredients;
            }
        }

        /// <summary>
        /// The constructor for the Fryceritops side. Sets the calories and price to the values for the small side.
        /// </summary>
        public Fryceritops()
        {
            Calories = 222;
            Price = 0.99;
        }
    }
}
