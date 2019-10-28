/*  FlavorSelection.xaml.cs
*   Author: Andrew Booze
*/

using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        /// <summary>
        /// The constructor for this page. Adds a button for each flavor.
        /// </summary>
        public FlavorSelection()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += DrinkSelection_CurrentChanged;
            }
            UpdateFlavorButtons();
        }

        // Updates flavor buttons when the current selection changes
        private void DrinkSelection_CurrentChanged(object sender, EventArgs e)
        {
            UpdateFlavorButtons();
        }

        // Preforms any actions necessary when a flavor button is clicked
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Adds buttons for each flavor to the menu programatically.
            List<SodasaurusFlavor> sodasaurusFlavors = new List<SodasaurusFlavor>
            {
                SodasaurusFlavor.Cola,
                SodasaurusFlavor.Orange,
                SodasaurusFlavor.Vanilla,
                SodasaurusFlavor.Chocolate,
                SodasaurusFlavor.RootBeer,
                SodasaurusFlavor.Cherry,
                SodasaurusFlavor.Lime,
                SodasaurusFlavor.Grape
            };

            if (sender is Button button && DataContext is Order order && 
                CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
            {
                if (button.Name == App.CreateValidIdString(SodasaurusFlavor.Cola.ToString()))
                {
                    // Swaps the flavor: If it already exists then the operation removes it, otherwise, 
                    // the operation adds it.
                    soda.Flavor ^= SodasaurusFlavor.Cola;
                }
                else if (button.Name == App.CreateValidIdString(SodasaurusFlavor.Orange.ToString()))
                {
                    soda.Flavor ^= SodasaurusFlavor.Orange;
                }
                else if (button.Name == App.CreateValidIdString(SodasaurusFlavor.Vanilla.ToString()))
                {
                    soda.Flavor ^= SodasaurusFlavor.Vanilla;
                }
                else if (button.Name == App.CreateValidIdString(SodasaurusFlavor.Chocolate.ToString()))
                {
                    soda.Flavor ^= SodasaurusFlavor.Chocolate;
                }
                else if (button.Name == App.CreateValidIdString(SodasaurusFlavor.RootBeer.ToString()))
                {
                    soda.Flavor ^= SodasaurusFlavor.RootBeer;
                }
                else if (button.Name == App.CreateValidIdString(SodasaurusFlavor.Cherry.ToString()))
                {
                    soda.Flavor ^= SodasaurusFlavor.Cherry;
                }
                else if (button.Name == App.CreateValidIdString(SodasaurusFlavor.Lime.ToString()))
                {
                    soda.Flavor ^= SodasaurusFlavor.Lime;
                }
                else if (button.Name == App.CreateValidIdString(SodasaurusFlavor.Grape.ToString()))
                {
                    soda.Flavor ^= SodasaurusFlavor.Grape;
                }
            }

            UpdateFlavorButtons();
        }

        // Adds buttons for each flavor to the menu programatically.
        private void UpdateFlavorButtons()
        {
            while (FlavorGrid.Children.Count > 0)
            {
                FlavorGrid.Children.RemoveAt(0);
            }

            List<SodasaurusFlavor> sodasaurusFlavors = new List<SodasaurusFlavor>
            {
                SodasaurusFlavor.Cola,
                SodasaurusFlavor.Orange,
                SodasaurusFlavor.Vanilla,
                SodasaurusFlavor.Chocolate,
                SodasaurusFlavor.RootBeer,
                SodasaurusFlavor.Cherry,
                SodasaurusFlavor.Lime,
                SodasaurusFlavor.Grape
            };
            int x = 0;
            int y = 0;

            foreach (SodasaurusFlavor flavor in sodasaurusFlavors)
            {
                TextBlock textBlock = new TextBlock
                {
                    Text = flavor.ToString(),
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                };

                Button button = new Button
                {
                    Content = textBlock,
                    Name = App.CreateValidIdString(flavor.ToString())
                };

                button.SetValue(Grid.ColumnProperty, x++);
                button.SetValue(Grid.RowProperty, y);

                if (x >= 3)
                {
                    y++;
                    x = 0;
                }

                if (DataContext is Order order &&
                    CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda &&
                    soda.Flavor.HasFlag(flavor))
                {
                    button.Background = Brushes.LightGreen;
                }

                button.Click += new RoutedEventHandler(Button_Click);
                FlavorGrid.Children.Add(button);
            }
        }

        // Returns to the DrinkSelection screen when clicked.
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
