/*  OrderControl.xaml.cs
*   Author: Andrew Booze
*/

using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using MenuItem = DinoDiner.Menu.MenuItem;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// The Navigation Service for the OrderControl
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
                if (element.DataContext is MenuItem item)
                {
                    order.Items.Remove(item);
                }
            }
        }

        /// <summary>
        /// When the selection is changed, navigate to the correct page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrderListBox.Items.Count <= 0 && !(NavigationService.Content is MenuCategorySelection))
            {
                NavigationService?.Navigate(new MenuCategorySelection());
            }
            else if (OrderListBox.SelectedItem is Side && !(NavigationService.Content is SideSelection))
            {
                NavigationService?.Navigate(new SideSelection());
            }
            else if (OrderListBox.SelectedItem is PterodactylWings && !(NavigationService.Content is EntreeSelection))
            {
                NavigationService?.Navigate(new EntreeSelection());
            }
            else if (OrderListBox.SelectedItem is Entree && !(NavigationService.Content is CustomizeEntree))
            {
                NavigationService?.Navigate(new CustomizeEntree());
            }
            else if (OrderListBox.SelectedItem is Drink && !(NavigationService.Content is DrinkSelection))
            {
                NavigationService?.Navigate(new DrinkSelection());
            }
            else if (OrderListBox.SelectedItem is CretaceousCombo && 
                !(NavigationService.Content is CustomizeCombo))
            {
                NavigationService?.Navigate(new CustomizeCombo());
            }
        }

        private void BottomButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (button.Name == "CancelButton")
                {
                    order.Items.Clear();
                }
                else    // Pay button
                {
                    // Also clear all items for the moment
                    order.Items.Clear();
                }
            }
        }
    }
}
