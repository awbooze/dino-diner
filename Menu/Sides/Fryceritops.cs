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
        /// The constructor for the Fryceritops side. Sets the calories and price to the value for the small side.
        /// </summary>
        public Fryceritops()
        {
            Calories = 222;
            Price = 0.99;
        }
    }
}
