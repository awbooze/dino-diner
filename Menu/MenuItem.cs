/*  MenuItem.cs
*   Author: Andrew Booze
*/

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The base class for all menu items. Provides Price, Calories, and abstract Ingredent list. 
    /// </summary>
    public abstract class MenuItem
    {
        /// <summary>
        /// The price of this menu item.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// The number of calories in this menu item.
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// The list of ingredients for this menu item.
        /// </summary>
        public abstract List<string> Ingredients { get; }
    }
}
