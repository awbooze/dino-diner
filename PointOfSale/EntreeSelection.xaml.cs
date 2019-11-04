/*  EntreeSelection.xaml.cs
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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// The constructor for this page. Adds a button for each entree.
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();

            // Adds buttons for each entree to the menu programatically.
            Menu menu = new Menu();
            int x = 0;
            int y = 0;

            foreach (Entree entree in menu.AvailableEntrees)
            {
                TextBlock textBlock = new TextBlock
                {
                    Text = entree.ToString(),
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                };

                Button button = new Button
                {
                    Content = textBlock,
                    Name = App.CreateValidIdString(entree.ToString())
                };

                button.SetValue(Grid.ColumnProperty, x++);
                button.SetValue(Grid.RowProperty, y);

                if (x >= 3)
                {
                    y++;
                    x = 0;
                }

                button.Click += new RoutedEventHandler(Button_Click);
                EntreeGrid.Children.Add(button);
            }
        }

        // Performs any actions necessary when an entree button is clicked.
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (button.Name == App.CreateValidIdString(new Brontowurst().ToString()))
                {
                    order.Items.Add(new Brontowurst());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (button.Name == App.CreateValidIdString(new DinoNuggets().ToString()))
                {
                    order.Items.Add(new DinoNuggets());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (button.Name == App.CreateValidIdString(new PrehistoricPBJ().ToString()))
                {
                    order.Items.Add(new PrehistoricPBJ());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (button.Name == App.CreateValidIdString(new PterodactylWings().ToString()))
                {
                    order.Items.Add(new PterodactylWings());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (button.Name == App.CreateValidIdString(new SteakosaurusBurger().ToString()))
                {
                    order.Items.Add(new SteakosaurusBurger());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (button.Name == App.CreateValidIdString(new TRexKingBurger().ToString()))
                {
                    order.Items.Add(new TRexKingBurger());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else if (button.Name == App.CreateValidIdString(new VelociWrap().ToString()))
                {
                    order.Items.Add(new VelociWrap());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else
                {
                    throw new InvalidOperationException("Cannot add any other entree with the buttons on this screen.");
                }

                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo)
                {
                    NavigationService.Navigate(new CustomizeCombo());
                }
                else
                {
                    NavigationService.Navigate(new MenuCategorySelection());
                }
            }
        }

        // Returns to the MenuCategorySelection screen when clicked.
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
