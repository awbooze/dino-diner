/*  OrderControl.xaml.cs
*   Author: Andrew Booze
*/

using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// The Navigation Service for the OrderControl (not currently working)
        /// </summary>
        public NavigationService NavigationService { get; set; }

        /// <summary>
        /// The constructor for this control. Builds the control from the attached XAML file. 
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
        }

        // Removes the appropriate item from the list when the remove button is clicked.
        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order && sender is FrameworkElement element)
            {
                if (element.DataContext is IOrderItem item)
                {
                    order.Items.Remove(item);
                }
            }
        }

        // Might want to remove this on Saturday because it creates an entirely new page every time.
        private void OrderListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrderListBox.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection());
            }
            else if (OrderListBox.SelectedItem is Entree entree)
            {
                NavigationService?.Navigate(new EntreeSelection());
            }
            else if (OrderListBox.SelectedItem is Drink drink)
            {
                NavigationService?.Navigate(new DrinkSelection());
            }
        }
    }
}
