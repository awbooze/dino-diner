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
        public NavigationService NavigationService { get; set; }

        public OrderControl()
        {
            InitializeComponent();
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (sender is FrameworkElement element)
                {
                    if (element.DataContext is IOrderItem item)
                    {
                        order.Items.Remove(item);
                    }
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
