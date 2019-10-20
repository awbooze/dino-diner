/*  Drink.cs
*   Author: Andrew Booze
*/

namespace DinoDiner.Menu
{
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
            if (Ice)
            {
                Ice = false;
                special.Add("Hold Ice");
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
            }
        }
    }
}
