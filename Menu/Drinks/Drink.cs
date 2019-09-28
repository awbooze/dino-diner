/*  Drink.cs
*   Author: Andrew Booze
*/

namespace DinoDiner.Menu.Drinks
{
    /// <summary>
    /// An enum with three drink sizes: small, medium, and large.
    /// </summary>
    public enum Size
    {
        /// <summary>
        /// The small size.
        /// </summary>
        Small,

        /// <summary>
        /// The medium size.
        /// </summary>
        Medium,

        /// <summary>
        /// The large size.
        /// </summary>
        Large
    }

    /// <summary>
    /// The base drink class. Extends MenuItem, so inherits Price, Calories, and Ingredients.
    /// </summary>
    public abstract class Drink : MenuItem
    {
        /// <summary>
        /// Gets or sets the size of this drink.
        /// </summary>
        public abstract Size Size { get; set; }

        /// <summary>
        /// Gets or sets whether there is ice in this drink.
        /// </summary>
        public virtual bool Ice { get; protected set; } = true;

        /// <summary>
        /// Allows the user to hold the ice in this drink.
        /// </summary>
        public virtual void HoldIce()
        {
            Ice = false;
        }
    }
}
