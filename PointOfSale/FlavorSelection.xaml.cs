/*  FlavorSelection.xaml.cs
*   Author: Andrew Booze
*/

using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

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

                button.Click += new RoutedEventHandler(Button_Click);
                FlavorGrid.Children.Add(button);
            }
        }

        // Preforms any actions necessary when a flavor button is clicked
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
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
