/*  SideSelection.xaml.cs
*   Author: Andrew Booze
*/

using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Menu = DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        /// <summary>
        /// The constructor for this page. Adds buttons for all the sides and radio buttons for the sizes.
        /// </summary>
        public SideSelection()
        {
            InitializeComponent();

            List<Menu.Size> sizes = new List<Menu.Size>
            {
                Menu.Size.Small,
                Menu.Size.Medium,
                Menu.Size.Large
            };

            // Adds buttons for each entree to the menu programatically.
            Menu.Menu menu = new Menu.Menu();
            int x = 0;
            int y = 0;

            foreach (Side side in menu.AvailableSides)
            {
                Button button = new Button
                {
                    Content = new TextBlock
                    {
                        Text = App.CorrectDrinkAndSideNames(side.ToString()),
                        TextWrapping = TextWrapping.Wrap,
                        TextAlignment = TextAlignment.Center
                    },
                    Name = App.CreateValidIdString(side.ToString())
                };

                button.SetValue(Grid.ColumnProperty, x++);
                button.SetValue(Grid.RowProperty, y);

                if (x >= 2)
                {
                    y++;
                    x = 0;
                }

                button.Click += new RoutedEventHandler(Button_Click);
                SideGrid.Children.Add(button);
            }

            SizeGrid.RowDefinitions.Add(new RowDefinition());
            x = 0;

            foreach (Menu.Size size in sizes)
            {
                RadioButton radioButton = new RadioButton
                {
                    Content = size.ToString(),
                    Name = size.ToString(),
                    IsChecked = (size.ToString() == "Small")
                };

                SizeGrid.ColumnDefinitions.Add(new ColumnDefinition());
                radioButton.SetValue(Grid.ColumnProperty, x++);
                radioButton.SetValue(Grid.RowProperty, 0);

                SizeGrid.Children.Add(radioButton);
            }
        }

        // Performs any action required by clicking on one of the sides
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
