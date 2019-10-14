/*  CustomizeCombo.xaml.cs
*   Author: Andrew Booze
*/

using DinoDiner.Menu;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Menu = DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// The constructor for this page. Adds text for sides and drinks and adds the radio buttons 
        /// for each size.
        /// </summary>
        public CustomizeCombo()
        {
            InitializeComponent();

            // We should have the actual combo to grab the side from. However, we are not implemnting that 
            // system for this milestone, so I will just create a new one.
            CretaceousCombo combo = new CretaceousCombo(new DinoNuggets());
            List<Menu.Size> sizes = new List<Menu.Size>
            {
                Menu.Size.Small,
                Menu.Size.Medium,
                Menu.Size.Large
            };
            int x = 0;

            // Change text of button for Sides
            TextBlock sideText = SideButton.Content as TextBlock;
            sideText.Text = "Side: " + App.CorrectDrinkAndSideNames(combo.Side.ToString());

            // Change text of button for Drinks
            TextBlock drinkText = DrinkButton.Content as TextBlock;
            drinkText.Text = "Drink: " + App.CorrectDrinkAndSideNames(combo.Drink.ToString());

            // Add sizes
            foreach (Menu.Size size in sizes)
            {
                RadioButton radioButton = new RadioButton
                {
                    Content = size.ToString(),
                    Name = size.ToString(),
                    IsChecked = (size.ToString() == "Small")
                };

                radioButton.SetValue(Grid.ColumnProperty, x);
                radioButton.SetValue(Grid.RowProperty, 1);
                radioButton.SetValue(Grid.ColumnSpanProperty, 2);

                CustomizeGrid.Children.Add(radioButton);

                x += 2;
            }
        }

        // Navigates to either the SideSelection or DrinkSelection screens based on the button pressed
        private void ChangeButtons_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button.Name == "SideButton")
            {
                NavigationService.Navigate(new SideSelection());
            }
            else
            {
                NavigationService.Navigate(new DrinkSelection());
            }
        }
    }
}
