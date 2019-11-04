/*  CustomizeCombo.xaml.cs
*   Author: Andrew Booze
*/

using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
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

            UpdateDrinkAndSideButtons(combo);

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

                radioButton.Checked += RadioButton_Checked;

                CustomizeGrid.Children.Add(radioButton);

                x += 2;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += CustomizeCombo_CurrentChanged;

                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    UpdateDrinkAndSideButtons(combo);
                    UpdateRadioButtons(combo);
                }
            }
        }

        private void CustomizeCombo_CurrentChanged(object sender, EventArgs e)
        {
            if (DataContext is Order order && 
                CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
            {
                UpdateDrinkAndSideButtons(combo);
                UpdateRadioButtons(combo);
            }
        }

        private void UpdateDrinkAndSideButtons(CretaceousCombo combo)
        {
            // Change text of button for Sides
            TextBlock sideText = SideButton.Content as TextBlock;
            sideText.Text = "Side: " + combo.Side.ToString();

            // Change text of button for Drinks
            TextBlock drinkText = DrinkButton.Content as TextBlock;
            drinkText.Text = "Drink: " + combo.Drink.ToString();
        }

        // Change radio buttons to correct size
        private void UpdateRadioButtons(CretaceousCombo combo)
        {
            RadioButton smallRadio = CustomizeGrid.Children[4] as RadioButton;
            RadioButton mediumRadio = CustomizeGrid.Children[5] as RadioButton;
            RadioButton largeRadio = CustomizeGrid.Children[6] as RadioButton;

            if (combo.Size == Menu.Size.Small)
            {
                smallRadio.IsChecked = true;
            }
            else if (combo.Size == Menu.Size.Medium)
            {
                mediumRadio.IsChecked = true;
            }
            else
            {
                largeRadio.IsChecked = true;
            }
        }

        // Navigates to either the SideSelection or DrinkSelection screens based on the button pressed
        private void ChangeButtons_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button.Name == "SideButton")
            {
                NavigationService?.Navigate(new SideSelection(true));
            }
            else
            {
                NavigationService?.Navigate(new DrinkSelection(true));
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton && DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (radioButton.Name == Menu.Size.Small.ToString())
                    {
                        combo.Size = Menu.Size.Small;
                    }
                    else if (radioButton.Name == Menu.Size.Medium.ToString())
                    {
                        combo.Size = Menu.Size.Medium;
                    }
                    else if (radioButton.Name == Menu.Size.Large.ToString())
                    {
                        combo.Size = Menu.Size.Large;
                    }
                }
            }
        }

        // Returns to the MenuCategorySelection screen when clicked.
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new MenuCategorySelection());
        }

        // Goes back to the customize entree screen.
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
