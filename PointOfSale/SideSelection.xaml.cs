/*  SideSelection.xaml.cs
*   Author: Andrew Booze
*/

using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
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

                radioButton.Checked += RadioButton_Checked;

                SizeGrid.Children.Add(radioButton);

                // Not quite working at the moment.
                /*if (DataContext is Order order)
                {
                    CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += SideSelection_CurrentChanged;
                }*/
            }
        }

        private void SideSelection_CurrentChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        // Performs any action required by clicking on one of the sides
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (button.Name == App.CreateValidIdString(new Fryceritops().ToString()))
                {
                    order.Items.Add(new Fryceritops());
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
                else
                {
                    throw new NotImplementedException();
                }
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton && DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    if (radioButton.Name == Menu.Size.Small.ToString())
                    {
                        side.Size = Menu.Size.Small;
                    }
                    else if (radioButton.Name == Menu.Size.Medium.ToString())
                    {
                        side.Size = Menu.Size.Medium;
                    }
                    else if (radioButton.Name == Menu.Size.Large.ToString())
                    {
                        side.Size = Menu.Size.Large;
                    }
                }
            }
        }
    }
}
