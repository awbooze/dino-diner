using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        public MenuCategorySelection()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs args)
        {
            Button buttonClicked = sender as Button;
            if (buttonClicked.Name == "ComboButton")
            {
                NavigationService.Navigate(new ComboSelection());
            }
            else if (buttonClicked.Name == "EntreeButton")
            {
                NavigationService.Navigate(new EntreeSelection());
            }
            else if (buttonClicked.Name == "SideButton")
            {
                NavigationService.Navigate(new SideSelection());
            }
            else // Drink button
            {
                NavigationService.Navigate(new DrinkSelection());
            }
        }
    }
}
