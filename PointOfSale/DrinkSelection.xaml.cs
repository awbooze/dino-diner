using DinoDiner.Menu;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Menu = DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
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
                TextBlock textBlock = new TextBlock
                {
                    Text = App.CorrectDrinkAndEntreeNames(drink.ToString()),
                    TextWrapping = TextWrapping.Wrap,
                    TextAlignment = TextAlignment.Center
                };

                Button button = new Button
                {
                    Content = textBlock,
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
                    Name = size.ToString()
                };

                SizeGrid.ColumnDefinitions.Add(new ColumnDefinition());
                radioButton.SetValue(Grid.ColumnProperty, x++);
                radioButton.SetValue(Grid.RowProperty, 0);

                SizeGrid.Children.Add(radioButton);
            }

            ResponsiveButton.Content = "Choose a drink";
        }

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

                addIceButton.Click += JJava_Click;
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

                roomForCreamButton.Click += JJava_Click;
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

                decalfButton.Click += JJava_Click;
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

        private void Soda_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button.Name == "flavorButton")
            {
                NavigationService.Navigate(new FlavorSelection());
            }
        }

        private void JJava_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Tea_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Water_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
