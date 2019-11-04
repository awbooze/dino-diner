/*  Order.cs
*   Author: Andrew Booze
*/

using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class that represents a customer order.
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// The PropertyChangedEventHandler for NotifyOfPropertyChanged.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Stores all the items that the customer has currently added to the order as an ObservableCollection.
        /// </summary>
        public ObservableCollection<MenuItem> Items { get; set; } = new ObservableCollection<MenuItem>();

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

        /// <summary>
        /// Default no-argument contstructor for the Order object.
        /// </summary>
        public Order()
        {
            Items.CollectionChanged += Items_CollectionChanged;
        }

        // Private event handler called when the items in the order change.
        private void Items_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            // Code adapted from answers to 
            // https://stackoverflow.com/questions/1427471/observablecollection-not-noticing-when-item-in-it-changes-even-with-inotifyprop
            // by Martin Harris and simon under MIT License.
            if (e.OldItems != null)
            {
                foreach (MenuItem item in e.OldItems)
                {
                    //Removed items
                    item.PropertyChanged -= MenuItemPropertyChanged;
                }
            }
            else if (e.NewItems != null)
            {
                foreach (MenuItem item in e.NewItems)
                {
                    //Added items
                    item.PropertyChanged += MenuItemPropertyChanged;
                }
            }
            // End adapted code

            NotifyOfPropertyChanged("Items");
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("TotalCost");
        }

        // Private event handler called when a property of an item in the order changes.
        private void MenuItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("TotalCost");
        }

        /// <summary>
        /// Call to notify other listeners that a property described by the property name has changed.
        /// </summary>
        /// <param name="propertyName">The name of the property that has changed.</param>
        public void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
