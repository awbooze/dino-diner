/*  DrinkSelection.xaml.cs
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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// The constructor for this page. Adds a button for each drink and the radio buttons for the sizes.
        /// </summary>
        public DrinkSelection()
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
            DrinkGrid.RowDefinitions.Add(new RowDefinition());
            int x = 0;

            foreach (Drink drink in menu.AvailableDrinks)
            {
                Button button = new Button
                {
                    Content = new TextBlock
                    {
                        Text = App.CorrectDrinkAndSideNames(drink.ToString()),
                        TextWrapping = TextWrapping.Wrap,
                        TextAlignment = TextAlignment.Center
                    },
                    Name = App.CreateValidIdString(drink.ToString())
                };

                DrinkGrid.ColumnDefinitions.Add(new ColumnDefinition());
                button.SetValue(Grid.ColumnProperty, x++);
                button.SetValue(Grid.RowProperty, 0);

                button.Click += new RoutedEventHandler(Button_Click);
                DrinkGrid.Children.Add(button);
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
            }
        }

        /// <summary>
        /// Removes all buttons in the third row of the app, then re-adds buttons that are applicable to the 
        /// current drink.
        /// </summary>
        /// <param name="sender">The button that was pressed.</param>
        /// <param name="e">Any arguments about the event.</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button.Name == App.CreateValidIdString(new Sodasaurus().ToString()))
            {
                while (SpecialGrid.Children.Count > 0)
                {
                    SpecialGrid.Children.RemoveAt(0);
                }

                Button holdIceButton = new Button
                {
                    Content = new TextBlock
                    {
                        Text = "Hold Ice",
                        TextWrapping = TextWrapping.WrapWithOverflow,
                        TextAlignment = TextAlignment.Center
                    },
                    Name = "holdIceButton",
                };

                holdIceButton.SetValue(Grid.ColumnProperty, 0);
                holdIceButton.SetValue(Grid.ColumnSpanProperty, 3);

                holdIceButton.Click += Soda_Click;
                SpecialGrid.Children.Add(holdIceButton);

                Button flavorButton = new Button
                {
                    Content = new TextBlock
                    {
                        Text = "Flavor",
                        TextWrapping = TextWrapping.WrapWithOverflow,
                        TextAlignment = TextAlignment.Center
                    },
                    Name = "flavorButton",
                };

                flavorButton.SetValue(Grid.ColumnProperty, 3);
                flavorButton.SetValue(Grid.ColumnSpanProperty, 3);

                flavorButton.Click += Soda_Click;
                SpecialGrid.Children.Add(flavorButton);
            }
            else if (button.Name == App.CreateValidIdString(new JurassicJava().ToString()))
            {
                while (SpecialGrid.Children.Count > 0)
                {
                    SpecialGrid.Children.RemoveAt(0);
                }

                Button addIceButton = new Button
                {
                    Content = new TextBlock
                    {
                        Text = "Add Ice",
                        TextWrapping = TextWrapping.WrapWithOverflow,
                        TextAlignment = TextAlignment.Center
                    },
                    Name = "addIceButton",
                };

                addIceButton.SetValue(Grid.ColumnProperty, 0);
                addIceButton.SetValue(Grid.ColumnSpanProperty, 2);

                addIceButton.Click += Java_Click;
                SpecialGrid.Children.Add(addIceButton);

                Button roomForCreamButton = new Button
                {
                    Content = new TextBlock
                    {
                        Text = "Leave Room for Cream",
                        TextWrapping = TextWrapping.WrapWithOverflow,
                        TextAlignment = TextAlignment.Center
                    },
                    Name = "roomForCreamButton",
                };

                roomForCreamButton.SetValue(Grid.ColumnProperty, 2);
                roomForCreamButton.SetValue(Grid.ColumnSpanProperty, 2);

                roomForCreamButton.Click += Java_Click;
                SpecialGrid.Children.Add(roomForCreamButton);

                Button decalfButton = new Button
                {
                    Content = new TextBlock
                    {
                        Text = "Make Decalf",
                        TextWrapping = TextWrapping.WrapWithOverflow,
                        TextAlignment = TextAlignment.Center
                    },
                    Name = "decalfButton",
                };

                decalfButton.SetValue(Grid.ColumnProperty, 4);
                decalfButton.SetValue(Grid.ColumnSpanProperty, 2);

                decalfButton.Click += Java_Click;
                SpecialGrid.Children.Add(decalfButton);
            }
            else if (button.Name == App.CreateValidIdString(new Tyrannotea().ToString()))
            {
                while (SpecialGrid.Children.Count > 0)
                {
                    SpecialGrid.Children.RemoveAt(0);
                }

                Button holdIceButton = new Button
                {
                    Content = new TextBlock
                    {
                        Text = "Hold Ice",
                        TextWrapping = TextWrapping.WrapWithOverflow,
                        TextAlignment = TextAlignment.Center
                    },
                    Name = "holdIceButton",
                };

                holdIceButton.SetValue(Grid.ColumnProperty, 0);
                holdIceButton.SetValue(Grid.ColumnSpanProperty, 2);

                holdIceButton.Click += Tea_Click;
                SpecialGrid.Children.Add(holdIceButton);

                Button addLemonButton = new Button
                {
                    Content = new TextBlock
                    {
                        Text = "Add Lemon",
                        TextWrapping = TextWrapping.WrapWithOverflow,
                        TextAlignment = TextAlignment.Center
                    },
                    Name = "addLemonButton",
                };

                addLemonButton.SetValue(Grid.ColumnProperty, 2);
                addLemonButton.SetValue(Grid.ColumnSpanProperty, 2);

                addLemonButton.Click += Tea_Click;
                SpecialGrid.Children.Add(addLemonButton);

                Button makeSweetButton = new Button
                {
                    Content = new TextBlock
                    {
                        Text = "Make Sweet",
                        TextWrapping = TextWrapping.WrapWithOverflow,
                        TextAlignment = TextAlignment.Center
                    },
                    Name = "makeSweetButton",
                };

                makeSweetButton.SetValue(Grid.ColumnProperty, 4);
                makeSweetButton.SetValue(Grid.ColumnSpanProperty, 2);

                makeSweetButton.Click += Tea_Click;
                SpecialGrid.Children.Add(makeSweetButton);
            }
            else    // Water
            {
                while (SpecialGrid.Children.Count > 0)
                {
                    SpecialGrid.Children.RemoveAt(0);
                }

                Button holdIceButton = new Button
                {
                    Content = new TextBlock
                    {
                        Text = "Hold Ice",
                        TextWrapping = TextWrapping.WrapWithOverflow,
                        TextAlignment = TextAlignment.Center
                    },
                    Name = "holdIceButton",
                };

                holdIceButton.SetValue(Grid.ColumnProperty, 0);
                holdIceButton.SetValue(Grid.ColumnSpanProperty, 3);

                holdIceButton.Click += Water_Click;
                SpecialGrid.Children.Add(holdIceButton);

                Button addLemonButton = new Button
                {
                    Content = new TextBlock
                    {
                        Text = "Add Lemon",
                        TextWrapping = TextWrapping.WrapWithOverflow,
                        TextAlignment = TextAlignment.Center
                    },
                    Name = "addLemonButton",
                };

                addLemonButton.SetValue(Grid.ColumnProperty, 3);
                addLemonButton.SetValue(Grid.ColumnSpanProperty, 3);

                addLemonButton.Click += Water_Click;
                SpecialGrid.Children.Add(addLemonButton);
            }
        }

        // Changes drink size when appropriate.
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton radioButton && DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    if (radioButton.Name == Menu.Size.Small.ToString())
                    {
                        drink.Size = Menu.Size.Small;
                    }
                    else if (radioButton.Name == Menu.Size.Medium.ToString())
                    {
                        drink.Size = Menu.Size.Medium;
                    }
                    else if (radioButton.Name == Menu.Size.Large.ToString())
                    {
                        drink.Size = Menu.Size.Large;
                    }
                }
            }
        }

        // Performs soda-related actions when soda-related buttons are clicked
        private void Soda_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button.Name == "flavorButton")
            {
                NavigationService.Navigate(new FlavorSelection());
            }
        }

        // Performs java-related actions when java-related buttons are clicked
        private void Java_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        // Performs tea-related actions when tea-related buttons are clicked
        private void Tea_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        // Performs water-related actions when water-related buttons are clicked
        private void Water_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        // Returns to the MenuCategorySelection screen when clicked.
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
