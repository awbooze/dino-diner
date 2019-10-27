/*  MenuCategorySelection.xaml.cs
*   Author: Andrew Booze
*/

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
        /// <summary>
        /// The constructor for this page. Intitializes all components defined in MainCategorySelection.xaml.
        /// </summary>
        public MenuCategorySelection()
        {
            InitializeComponent();

            // Remove back stack entries (will not be using them anyway)
            if (NavigationService != null)
            {
                while (NavigationService.CanGoBack)
                {
                    NavigationService?.RemoveBackEntry();
                }
            }
        }

        // Navigates to the right page depending on the button clicked
        private void Button_Click(object sender, RoutedEventArgs args)
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
