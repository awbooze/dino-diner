/*  IOrderItem.cs
*   Author: Andrew Booze
*/

namespace DinoDiner.Menu
{
    /// <summary>
    /// An interface that all items that can be ordered need to implement through the MenuItem base class.
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of this order item.
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The description of this order item.
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Any special requirements for this order.
        /// </summary>
        string[] Special { get; }
    }
}
