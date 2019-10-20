/*  MenuItem.cs
*   Author: Andrew Booze
*/

using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// The base class for all menu items. Provides Price, Calories, and an abstract list of ingredients.
    /// </summary>
    public abstract class MenuItem : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Powers the ability to add special requirements to the order.
        /// </summary>
        protected List<string> special = new List<string>();

        /// <summary>
        /// The PropertyChangedEventHandler for NotifyOfPropertyChanged.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The price of this menu item.
        /// </summary>
        public virtual double Price { get; set; }

        /// <summary>
        /// The number of calories in this menu item.
        /// </summary>
        public virtual uint Calories { get; set; }

        /// <summary>
        /// The list of ingredients for this menu item.
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// The description for this menu item. Relies on all derived classes overriding the ToString method 
        /// in their class.
        /// </summary>
        public virtual string Description => ToString();

        /// <summary>
        /// Any special requirements for this order. Typically collects special information as things are changed.
        /// </summary>
        public virtual string[] Special => special.ToArray();

        /// <summary>
        /// Call to notify other listeners that a property described by the property name has changed.
        /// </summary>
        /// <param name="propertyName">The name of the property that has changed.</param>
        public virtual void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
