/*  ComboSelection.xaml.cs
*   Author: Andrew Booze
*/

using DinoDiner.Menu;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Menu = DinoDiner.Menu.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        /// <summary>
        /// The constructor for this page. Adds a button for each combo.
        /// </summary>
        public ComboSelection()
        {
            InitializeComponent();

            // Adds buttons for each combo to the menu programatically.
            Menu menu = new Menu();
            int x = 0;
            int y = 0;

            foreach (CretaceousCombo combo in menu.AvailableCombos)
            {
                TextBlock textBlock = new TextBlock
                {
                    Text = combo.ToString(),
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                };

                Button button = new Button
                {
                    Content = textBlock,
                    Name = App.CreateValidIdString(combo.Entree.ToString())
                };

                button.SetValue(Grid.ColumnProperty, x++);
                button.SetValue(Grid.RowProperty, y);

                if (x >= 3)
                {
                    y++;
                    x = 0;
                }

                button.Click += new RoutedEventHandler(Button_Click);
                ComboGrid.Children.Add(button);
            }
        }

        // Navigates to the CustomizeCombo screen when any button pressed.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (button.Name == App.CreateValidIdString(new Brontowurst().ToString()))
                {
                    order.Items.Add(new CretaceousCombo(new Brontowurst()));
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (button.Name == App.CreateValidIdString(new DinoNuggets().ToString()))
                {
                    order.Items.Add(new CretaceousCombo(new DinoNuggets()));
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (button.Name == App.CreateValidIdString(new PrehistoricPBJ().ToString()))
                {
                    order.Items.Add(new CretaceousCombo(new PrehistoricPBJ()));
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (button.Name == App.CreateValidIdString(new PterodactylWings().ToString()))
                {
                    order.Items.Add(new CretaceousCombo(new PterodactylWings()));
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (button.Name == App.CreateValidIdString(new SteakosaurusBurger().ToString()))
                {
                    order.Items.Add(new CretaceousCombo(new SteakosaurusBurger()));
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (button.Name == App.CreateValidIdString(new TRexKingBurger().ToString()))
                {
                    order.Items.Add(new CretaceousCombo(new TRexKingBurger()));
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (button.Name == App.CreateValidIdString(new VelociWrap().ToString()))
                {
                    order.Items.Add(new CretaceousCombo(new VelociWrap()));
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else
                {
                    throw new InvalidOperationException("Cannot add any other entree with the buttons on this screen.");
                }
            }

            // No matter what, go to the customize combo screen
            NavigationService.Navigate(new CustomizeCombo());
        }

        // Returns to the MenuCategorySelection screen when clicked.
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
