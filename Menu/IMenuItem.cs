/*  IMenuItem.cs
*   Author: Andrew Booze
*/

using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// An interface that all menu items need to implement through the MenuItem base class.
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// The price of this menu item.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The number of calories in this menu item.
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// The list of ingredients for this menu item.
        /// </summary>
        List<string> Ingredients { get; }
    }
}
