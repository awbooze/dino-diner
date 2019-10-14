using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DinoDiner.Menu;
using Menu = DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
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
