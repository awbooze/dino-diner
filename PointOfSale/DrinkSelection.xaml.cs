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
        // Private backing variable.
        bool shouldChangeCombo = false;

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

            // Adds buttons for each drink to the menu programatically.
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
        /// Another constructor for this page. Allows me to determine whether this is from a combo or a regular page
        /// </summary>
        /// <param name="fromCombo">Whether this page is instantiated from a combo page.</param>
        public DrinkSelection(bool fromCombo) : this()
        {
            shouldChangeCombo = fromCombo;
        }

        // After the page is loaded, add an event handler that triggers whenever the selection changes.
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += DrinkSelection_CurrentChanged;

                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    // Assign correct buttons if created because of the user clicking on a drink
                    if (drink is Sodasaurus)
                    {
                        ChangeToSodasaurusButtons();
                    }
                    else if (drink is JurassicJava)
                    {
                        ChangeToJurassicJavaButtons();
                    }
                    else if (drink is Tyrannotea)
                    {
                        ChangeToTyrannoteaButtons();
                    }
                    else if (drink is Water)
                    {
                        ChangeToWaterButtons();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    // Assign correct buttons if created because of the user clicking on a combo
                    if (combo.Drink is Sodasaurus)
                    {
                        ChangeToSodasaurusButtons();
                    }
                    else if (combo.Drink is JurassicJava)
                    {
                        ChangeToJurassicJavaButtons();
                    }
                    else if (combo.Drink is Tyrannotea)
                    {
                        ChangeToTyrannoteaButtons();
                    }
                    else if (combo.Drink is Water)
                    {
                        ChangeToWaterButtons();
                    }

                    UpdateRadioButtons(combo.Drink);
                }
            }
        }

        // When the current item after the selection changes is a drink, change the buttons to match.
        private void DrinkSelection_CurrentChanged(object sender, EventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Drink drink)
                {
                    // Assign correct buttons if created because of the user clicking on a drink
                    if (drink is Sodasaurus)
                    {
                        ChangeToSodasaurusButtons();
                    }
                    else if (drink is JurassicJava)
                    {
                        ChangeToJurassicJavaButtons();
                    }
                    else if (drink is Tyrannotea)
                    {
                        ChangeToTyrannoteaButtons();
                    }
                    else if (drink is Water)
                    {
                        ChangeToWaterButtons();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    // Assign correct buttons if created because of the user clicking on a combo
                    if (combo.Drink is Sodasaurus)
                    {
                        ChangeToSodasaurusButtons();
                    }
                    else if (combo.Drink is JurassicJava)
                    {
                        ChangeToJurassicJavaButtons();
                    }
                    else if (combo.Drink is Tyrannotea)
                    {
                        ChangeToTyrannoteaButtons();
                    }
                    else if (combo.Drink is Water)
                    {
                        ChangeToWaterButtons();
                    }

                    UpdateRadioButtons(combo.Drink);
                }
            }
        }

        // Change radio buttons to correct size
        private void UpdateRadioButtons(Drink drink)
        {
            RadioButton smallRadio = SizeGrid.Children[0] as RadioButton;
            RadioButton mediumRadio = SizeGrid.Children[1] as RadioButton;
            RadioButton largeRadio = SizeGrid.Children[2] as RadioButton;

            if (drink.Size == Menu.Size.Small)
            {
                smallRadio.IsChecked = true;
            }
            else if (drink.Size == Menu.Size.Medium)
            {
                mediumRadio.IsChecked = true;
            }
            else
            {
                largeRadio.IsChecked = true;
            }
        }

        /// <summary>
        /// Adds the drink to the order or the combo, as appropriate.
        /// </summary>
        /// <param name="sender">The button that was pressed.</param>
        /// <param name="e">Any arguments about the event.</param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && DataContext is Order order)
            {
                Drink drink;
                if (button.Name == App.CreateValidIdString(new Sodasaurus().ToString()))
                {
                    // Add Sodasaurus to order
                    drink = new Sodasaurus();
                    ChangeToSodasaurusButtons();
                }
                else if (button.Name == App.CreateValidIdString(new JurassicJava().ToString()))
                {
                    // Add JurassicJava to order
                    drink = new JurassicJava();
                    ChangeToJurassicJavaButtons();
                }
                else if (button.Name == App.CreateValidIdString(new Tyrannotea().ToString()))
                {
                    // Add Tyrannotea to order
                    drink = new Tyrannotea();
                    ChangeToTyrannoteaButtons();
                }
                else    // Water
                {
                    // Add Water to order
                    drink = new Water();
                    ChangeToWaterButtons();
                }

                // Change side to correct size after adding item to order
                RadioButton mediumRadio = SizeGrid.Children[1] as RadioButton;
                RadioButton largeRadio = SizeGrid.Children[2] as RadioButton;

                if ((bool)mediumRadio.IsChecked)
                {
                    drink.Size = Menu.Size.Medium;
                }
                else if ((bool)largeRadio.IsChecked)
                {
                    drink.Size = Menu.Size.Large;
                }

                if (shouldChangeCombo && 
                    CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Drink = drink;
                }
                else
                {
                    // Add the drink to the order
                    order.Items.Add(drink);

                    // Focus on the new drink
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
            }
        }

        // Removes all buttons and adds buttons for Sodasaurus
        private void ChangeToSodasaurusButtons()
        {
            RemoveAllSpecialButtons();

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

        // Performs soda-related actions when soda-related buttons are clicked
        private void Soda_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (button.Name == "flavorButton")
                {
                    NavigationService?.Navigate(new FlavorSelection());
                }
                else
                {
                    if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Sodasaurus soda)
                    {
                        soda.HoldIce();
                    }
                    else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo && 
                        combo.Drink is Sodasaurus drink)
                    {
                        drink.HoldIce();
                    }
                }
            }
        }

        // Removes all buttons and then adds buttons for JurassicJava
        private void ChangeToJurassicJavaButtons()
        {
            RemoveAllSpecialButtons();

            // Add buttons for JurassicJava
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

        // Performs java-related actions when java-related buttons are clicked
        private void Java_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is JurassicJava java)
                {
                    if (button.Name == "addIceButton")
                    {
                        java.AddIce();
                    }
                    else if (button.Name == "roomForCreamButton")
                    {
                        java.LeaveRoomForCream();
                    }
                    else
                    {
                        java.MakeDecaf();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo &&
                        combo.Drink is JurassicJava drink)
                {
                    if (button.Name == "addIceButton")
                    {
                        drink.AddIce();
                    }
                    else if (button.Name == "roomForCreamButton")
                    {
                        drink.LeaveRoomForCream();
                    }
                    else
                    {
                        drink.MakeDecaf();
                    }
                }
            }
        }

        // Removes all buttons and then adds buttons for Tyrannotea
        private void ChangeToTyrannoteaButtons()
        {
            RemoveAllSpecialButtons();

            // Add buttons for Tyrannotea
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

        // Performs tea-related actions when tea-related buttons are clicked
        private void Tea_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Tyrannotea tea)
                {
                    if (button.Name == "holdIceButton")
                    {
                        tea.HoldIce();
                    }
                    else if (button.Name == "addLemonButton")
                    {
                        tea.AddLemon();
                    }
                    else
                    {
                        tea.MakeSweet();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo &&
                        combo.Drink is Tyrannotea drink)
                {
                    if (button.Name == "holdIceButton")
                    {
                        drink.HoldIce();
                    }
                    else if (button.Name == "addLemonButton")
                    {
                        drink.AddLemon();
                    }
                    else
                    {
                        drink.MakeSweet();
                    }
                }
            }
        }

        // Removes all buttons and then adds buttons for Water
        private void ChangeToWaterButtons()
        {
            RemoveAllSpecialButtons();

            // Add buttons for Water
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

        // Performs water-related actions when water-related buttons are clicked
        private void Water_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Water water)
                {
                    if (button.Name == "holdIceButton")
                    {
                        water.HoldIce();
                    }
                    else
                    {
                        water.AddLemon();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo &&
                        combo.Drink is Water drink)
                {
                    if (button.Name == "holdIceButton")
                    {
                        drink.HoldIce();
                    }
                    else
                    {
                        drink.AddLemon();
                    }
                }
            }
        }

        // Removes all current special buttons
        private void RemoveAllSpecialButtons()
        {
            while (SpecialGrid.Children.Count > 0)
            {
                SpecialGrid.Children.RemoveAt(0);
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

        // Returns to the MenuCategorySelection screen when clicked.
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new MenuCategorySelection());
        }

        // Goes back in the page hierarchy.
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
    }
}
