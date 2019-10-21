/*  Order.cs
*   Author: Andrew Booze
*/

using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represents a customer order.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Stores all the items that the customer has currently added to the order as an ObservableCollection.
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }

        /// <summary>
        /// Calculates a subtotal for the order by adding the cost of all items. The subtotal is never allowed 
        /// to be zero.
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double toReturn = 0;
                foreach (IOrderItem item in Items)
                {
                    toReturn += item.Price;
                }

                if (toReturn < 0)
                {
                    toReturn = 0;
                }

                return toReturn;
            }
        }

        /// <summary>
        /// Gets or sets the sales tax rate for Dino Diner.
        /// </summary>
        public double SalesTaxRate { get; protected set; } = 0.0895;

        /// <summary>
        /// Calculates the cost of the sales tax on the order by multiplying the subtotal cost and the 
        /// sales tax rate.
        /// </summary>
        public double SalesTaxCost => SubtotalCost * SalesTaxRate;

        /// <summary>
        /// Calculates the total cost of the order by adding the subtotal cost and the sales tax cost.
        /// </summary>
        public double TotalCost => SubtotalCost + SalesTaxCost;
    }
}
