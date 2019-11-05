/*  CustomizeEntree.xaml.cs
*   Author: Andrew Booze
*/

using DinoDiner.Menu;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeEntree.xaml
    /// </summary>
    public partial class CustomizeEntree : Page
    {
        #region Initialization

        public CustomizeEntree()
        {
            InitializeComponent();
        }

        // After the page is loaded, add a listener that notifies the page whenever the current order item 
        // changes and change to the correct buttons.
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += EntreeSelection_CurrentChanged;

                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is Brontowurst)
                    {
                        ChangeToBrontowurstButtons();
                    }
                    else if (combo.Entree is DinoNuggets)
                    {
                        ChangeToDinoNuggetsButtons();
                    }
                    else if (combo.Entree is PrehistoricPBJ)
                    {
                        ChangeToPrehistoricPBJButtons();
                    }
                    else if (combo.Entree is SteakosaurusBurger)
                    {
                        ChangeToSteakosaurusBurgerButtons();
                    }
                    else if (combo.Entree is TRexKingBurger)
                    {
                        ChangeToTRexKingBurgerButtons();
                    }
                    else if (combo.Entree is VelociWrap)
                    {
                        ChangeToVelociWrapButtons();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Entree entree)
                {
                    if (entree is Brontowurst)
                    {
                        ChangeToBrontowurstButtons();
                    }
                    else if (entree is DinoNuggets)
                    {
                        ChangeToDinoNuggetsButtons();
                    }
                    else if (entree is PrehistoricPBJ)
                    {
                        ChangeToPrehistoricPBJButtons();
                    }
                    else if (entree is SteakosaurusBurger)
                    {
                        ChangeToSteakosaurusBurgerButtons();
                    }
                    else if (entree is TRexKingBurger)
                    {
                        ChangeToTRexKingBurgerButtons();
                    }
                    else if (entree is VelociWrap)
                    {
                        ChangeToVelociWrapButtons();
                    }
                }
            }
        }

        // When the selection changes, change to the correct buttons.
        private void EntreeSelection_CurrentChanged(object sender, EventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    if (combo.Entree is Brontowurst)
                    {
                        ChangeToBrontowurstButtons();
                    }
                    else if (combo.Entree is DinoNuggets)
                    {
                        ChangeToDinoNuggetsButtons();
                    }
                    else if (combo.Entree is PrehistoricPBJ)
                    {
                        ChangeToPrehistoricPBJButtons();
                    }
                    else if (combo.Entree is SteakosaurusBurger)
                    {
                        ChangeToSteakosaurusBurgerButtons();
                    }
                    else if (combo.Entree is TRexKingBurger)
                    {
                        ChangeToTRexKingBurgerButtons();
                    }
                    else if (combo.Entree is VelociWrap)
                    {
                        ChangeToVelociWrapButtons();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Entree entree)
                {
                    if (entree is Brontowurst)
                    {
                        ChangeToBrontowurstButtons();
                    }
                    else if (entree is DinoNuggets)
                    {
                        ChangeToDinoNuggetsButtons();
                    }
                    else if (entree is PrehistoricPBJ)
                    {
                        ChangeToPrehistoricPBJButtons();
                    }
                    else if (entree is SteakosaurusBurger)
                    {
                        ChangeToSteakosaurusBurgerButtons();
                    }
                    else if (entree is TRexKingBurger)
                    {
                        ChangeToTRexKingBurgerButtons();
                    }
                    else if (entree is VelociWrap)
                    {
                        ChangeToVelociWrapButtons();
                    }
                }
            }
        }

        #endregion

        #region Brontowurst

        private void ChangeToBrontowurstButtons()
        {
            RemoveAllSpecialButtons();

            // Add buttons for Brontowurst
            Button holdBunButton = new Button
            {
                Content = new TextBlock
                {
                    Text = "Hold Bun",
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                },
                Name = "holdBunButton",
            };

            holdBunButton.SetValue(Grid.RowProperty, 0);
            holdBunButton.SetValue(Grid.ColumnSpanProperty, 3);

            holdBunButton.Click += Brontowurst_Click;
            CustomizeGrid.Children.Add(holdBunButton);

            Button holdPeppersButton = new Button
            {
                Content = new TextBlock
                {
                    Text = "Hold Peppers",
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                },
                Name = "holdPeppersButton",
            };

            holdPeppersButton.SetValue(Grid.RowProperty, 1);
            holdPeppersButton.SetValue(Grid.ColumnSpanProperty, 3);

            holdPeppersButton.Click += Brontowurst_Click;
            CustomizeGrid.Children.Add(holdPeppersButton);

            Button holdOnionButton = new Button
            {
                Content = new TextBlock
                {
                    Text = "Hold Onion",
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                },
                Name = "holdOnionButton",
            };

            holdOnionButton.SetValue(Grid.RowProperty, 2);
            holdOnionButton.SetValue(Grid.ColumnSpanProperty, 3);

            holdOnionButton.Click += Brontowurst_Click;
            CustomizeGrid.Children.Add(holdOnionButton);
        }

        private void Brontowurst_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo &&
                    combo.Entree is Brontowurst brontowurst)
                {
                    if (button.Name == "holdBunButton")
                    {
                        brontowurst.HoldBun();
                    }
                    else if (button.Name == "holdPeppersButton")
                    {
                        brontowurst.HoldPeppers();
                    }
                    else
                    {
                        brontowurst.HoldOnion();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Brontowurst bronto)
                {
                    if (button.Name == "holdBunButton")
                    {
                        bronto.HoldBun();
                    }
                    else if (button.Name == "holdPeppersButton")
                    {
                        bronto.HoldPeppers();
                    }
                    else
                    {
                        bronto.HoldOnion();
                    }
                }
            }
        }

        #endregion

        #region Dino Nuggets

        private void ChangeToDinoNuggetsButtons()
        {
            RemoveAllSpecialButtons();

            Button addNuggetButton = new Button
            {
                Content = new TextBlock
                {
                    Text = "Add Nugget",
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                },
                Name = "addNuggetButton",
            };

            addNuggetButton.SetValue(Grid.RowProperty, 0);
            addNuggetButton.SetValue(Grid.ColumnSpanProperty, 3);

            addNuggetButton.Click += DinoNuggets_Click;
            CustomizeGrid.Children.Add(addNuggetButton);
        }

        // Adds nugget when add nugget button clicked.
        private void DinoNuggets_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button && DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo &&
                    combo.Entree is DinoNuggets dinoNuggets)
                {
                    dinoNuggets.AddNugget();
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is DinoNuggets nuggets)
                {
                    nuggets.AddNugget();
                }
            }
        }

        #endregion

        #region Prehistoric PB&J

        private void ChangeToPrehistoricPBJButtons()
        {
            RemoveAllSpecialButtons();

            Button holdPeanutButterButton = new Button
            {
                Content = new TextBlock
                {
                    Text = "Hold Peanut Butter",
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                },
                Name = "holdPeanutButterButton",
            };

            holdPeanutButterButton.SetValue(Grid.RowProperty, 0);
            holdPeanutButterButton.SetValue(Grid.ColumnSpanProperty, 3);

            holdPeanutButterButton.Click += PrehistoricPBJ_Click;
            CustomizeGrid.Children.Add(holdPeanutButterButton);

            Button holdJellyButton = new Button
            {
                Content = new TextBlock
                {
                    Text = "Hold Jelly",
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                },
                Name = "holdJellyButton",
            };

            holdJellyButton.SetValue(Grid.RowProperty, 1);
            holdJellyButton.SetValue(Grid.ColumnSpanProperty, 3);

            holdJellyButton.Click += PrehistoricPBJ_Click;
            CustomizeGrid.Children.Add(holdJellyButton);
        }

        private void PrehistoricPBJ_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo &&
                    combo.Entree is PrehistoricPBJ pbj)
                {
                    if (button.Name == "holdPeanutButterButton")
                    {
                        pbj.HoldPeanutButter();
                    }
                    else
                    {
                        pbj.HoldJelly();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is PrehistoricPBJ sandwitch)
                {
                    if (button.Name == "holdPeanutButterButton")
                    {
                        sandwitch.HoldPeanutButter();
                    }
                    else
                    {
                        sandwitch.HoldJelly();
                    }
                }
            }
        }

        #endregion

        #region Steakosaurus Burger

        private void ChangeToSteakosaurusBurgerButtons()
        {
            RemoveAllSpecialButtons();

            Button holdBunButton = new Button
            {
                Content = new TextBlock
                {
                    Text = "Hold Bun",
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                },
                Name = "holdBunButton",
            };

            holdBunButton.SetValue(Grid.ColumnProperty, 0);

            holdBunButton.Click += SteakosaurusBurger_Click;
            CustomizeGrid.Children.Add(holdBunButton);

            Button holdPickleButton = new Button
            {
                Content = new TextBlock
                {
                    Text = "Hold Pickle",
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                },
                Name = "holdPickleButton",
            };

            holdPickleButton.SetValue(Grid.ColumnProperty, 1);

            holdPickleButton.Click += SteakosaurusBurger_Click;
            CustomizeGrid.Children.Add(holdPickleButton);

            Button holdKetchupButton = new Button
            {
                Content = new TextBlock
                {
                    Text = "Hold Ketchup",
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                },
                Name = "holdKetchupButton",
            };

            holdKetchupButton.SetValue(Grid.ColumnProperty, 2);

            holdKetchupButton.Click += SteakosaurusBurger_Click;
            CustomizeGrid.Children.Add(holdKetchupButton);

            Button holdMustardButton = new Button
            {
                Content = new TextBlock
                {
                    Text = "Hold Mustard",
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                },
                Name = "holdMustardButton",
            };

            holdMustardButton.SetValue(Grid.ColumnProperty, 0);
            holdMustardButton.SetValue(Grid.RowProperty, 1);

            holdMustardButton.Click += SteakosaurusBurger_Click;
            CustomizeGrid.Children.Add(holdMustardButton);
        }

        private void SteakosaurusBurger_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo &&
                    combo.Entree is SteakosaurusBurger steakburger)
                {
                    if (button.Name == "holdBunButton")
                    {
                        steakburger.HoldBun();
                    }
                    else if (button.Name == "holdPickleButton")
                    {
                        steakburger.HoldPickle();
                    }
                    else if (button.Name == "holdKetchupButton")
                    {
                        steakburger.HoldKetchup();
                    }
                    else
                    {
                        steakburger.HoldMustard();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is SteakosaurusBurger burger)
                {
                    if (button.Name == "holdBunButton")
                    {
                        burger.HoldBun();
                    }
                    else if (button.Name == "holdPickleButton")
                    {
                        burger.HoldPickle();
                    }
                    else if (button.Name == "holdKetchupButton")
                    {
                        burger.HoldKetchup();
                    }
                    else
                    {
                        burger.HoldMustard();
                    }
                }
            }
        }

        #endregion

        #region T-Rex King Burger

        private void ChangeToTRexKingBurgerButtons()
        {
            RemoveAllSpecialButtons();

            // Hold bun button
            Button holdBunButton = new Button
            {
                Content = new TextBlock
                {
                    Text = "Hold Bun",
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                },
                Name = "holdBunButton",
            };

            holdBunButton.SetValue(Grid.ColumnProperty, 0);

            holdBunButton.Click += TRexKingBurger_Click;
            CustomizeGrid.Children.Add(holdBunButton);

            // Hold lettuce button
            Button holdLettuceButton = new Button
            {
                Content = new TextBlock
                {
                    Text = "Hold Lettuce",
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                },
                Name = "holdLettuceButton",
            };

            holdLettuceButton.SetValue(Grid.ColumnProperty, 1);

            holdLettuceButton.Click += TRexKingBurger_Click;
            CustomizeGrid.Children.Add(holdLettuceButton);

            // Hold tomato button
            Button holdTomatoButton = new Button
            {
                Content = new TextBlock
                {
                    Text = "Hold Tomato",
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                },
                Name = "holdTomatoButton",
            };

            holdTomatoButton.SetValue(Grid.ColumnProperty, 2);

            holdTomatoButton.Click += TRexKingBurger_Click;
            CustomizeGrid.Children.Add(holdTomatoButton);

            // Hold onion button
            Button holdOnionButton = new Button
            {
                Content = new TextBlock
                {
                    Text = "Hold Onion",
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                },
                Name = "holdOnionButton",
            };

            holdOnionButton.SetValue(Grid.ColumnProperty, 0);
            holdOnionButton.SetValue(Grid.RowProperty, 1);

            holdOnionButton.Click += TRexKingBurger_Click;
            CustomizeGrid.Children.Add(holdOnionButton);

            // Hold pickle button
            Button holdPickleButton = new Button
            {
                Content = new TextBlock
                {
                    Text = "Hold Pickle",
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                },
                Name = "holdPickleButton",
            };

            holdPickleButton.SetValue(Grid.ColumnProperty, 1);
            holdPickleButton.SetValue(Grid.RowProperty, 1);

            holdPickleButton.Click += TRexKingBurger_Click;
            CustomizeGrid.Children.Add(holdPickleButton);

            // Hold ketchup button
            Button holdKetchupButton = new Button
            {
                Content = new TextBlock
                {
                    Text = "Hold Ketchup",
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                },
                Name = "holdKetchupButton",
            };

            holdKetchupButton.SetValue(Grid.ColumnProperty, 2);
            holdKetchupButton.SetValue(Grid.RowProperty, 1);

            holdKetchupButton.Click += TRexKingBurger_Click;
            CustomizeGrid.Children.Add(holdKetchupButton);

            // Hold mustard button
            Button holdMustardButton = new Button
            {
                Content = new TextBlock
                {
                    Text = "Hold Mustard",
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                },
                Name = "holdMustardButton",
            };

            holdMustardButton.SetValue(Grid.ColumnProperty, 0);
            holdMustardButton.SetValue(Grid.RowProperty, 2);

            holdMustardButton.Click += TRexKingBurger_Click;
            CustomizeGrid.Children.Add(holdMustardButton);

            // Hold mayo button
            Button holdMayoButton = new Button
            {
                Content = new TextBlock
                {
                    Text = "Hold Mayo",
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                },
                Name = "holdMayoButton",
            };

            holdMayoButton.SetValue(Grid.ColumnProperty, 1);
            holdMayoButton.SetValue(Grid.RowProperty, 2);

            holdMayoButton.Click += TRexKingBurger_Click;
            CustomizeGrid.Children.Add(holdMayoButton);
        }

        private void TRexKingBurger_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo &&
                    combo.Entree is TRexKingBurger steakburger)
                {
                    if (button.Name == "holdBunButton")
                    {
                        steakburger.HoldBun();
                    }
                    else if (button.Name == "holdLettuceButton")
                    {
                        steakburger.HoldLettuce();
                    }
                    else if (button.Name == "holdTomatoButton")
                    {
                        steakburger.HoldTomato();
                    }
                    else if (button.Name == "holdOnionButton")
                    {
                        steakburger.HoldOnion();
                    }
                    else if (button.Name == "holdPickleButton")
                    {
                        steakburger.HoldPickle();
                    }
                    else if (button.Name == "holdKetchupButton")
                    {
                        steakburger.HoldKetchup();
                    }
                    else if (button.Name == "holdMustardButton")
                    {
                        steakburger.HoldMustard();
                    }
                    else
                    {
                        steakburger.HoldMayo();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is TRexKingBurger burger)
                {
                    if (button.Name == "holdBunButton")
                    {
                        burger.HoldBun();
                    }
                    else if (button.Name == "holdLettuceButton")
                    {
                        burger.HoldLettuce();
                    }
                    else if (button.Name == "holdTomatoButton")
                    {
                        burger.HoldTomato();
                    }
                    else if (button.Name == "holdOnionButton")
                    {
                        burger.HoldOnion();
                    }
                    else if (button.Name == "holdPickleButton")
                    {
                        burger.HoldPickle();
                    }
                    else if (button.Name == "holdKetchupButton")
                    {
                        burger.HoldKetchup();
                    }
                    else if (button.Name == "holdMustardButton")
                    {
                        burger.HoldMustard();
                    }
                    else
                    {
                        burger.HoldMayo();
                    }
                }
            }
        }

        #endregion

        #region Veloci-Wrap

        private void ChangeToVelociWrapButtons()
        {
            RemoveAllSpecialButtons();

            Button holdDressingButton = new Button
            {
                Content = new TextBlock
                {
                    Text = "Hold Dressing",
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                },
                Name = "holdDressingButton",
            };

            holdDressingButton.SetValue(Grid.RowProperty, 0);
            holdDressingButton.SetValue(Grid.ColumnSpanProperty, 3);

            holdDressingButton.Click += VelociWrap_Click;
            CustomizeGrid.Children.Add(holdDressingButton);

            Button holdLettuceButton = new Button
            {
                Content = new TextBlock
                {
                    Text = "Hold Lettuce",
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                },
                Name = "holdLettuceButton",
            };

            holdLettuceButton.SetValue(Grid.RowProperty, 1);
            holdLettuceButton.SetValue(Grid.ColumnSpanProperty, 3);

            holdLettuceButton.Click += VelociWrap_Click;
            CustomizeGrid.Children.Add(holdLettuceButton);

            Button holdCheeseButton = new Button
            {
                Content = new TextBlock
                {
                    Text = "Hold Cheese",
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                },
                Name = "holdCheesButton",
            };

            holdCheeseButton.SetValue(Grid.RowProperty, 2);
            holdCheeseButton.SetValue(Grid.ColumnSpanProperty, 3);

            holdCheeseButton.Click += VelociWrap_Click;
            CustomizeGrid.Children.Add(holdCheeseButton);
        }

        private void VelociWrap_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo &&
                    combo.Entree is VelociWrap velociWrap)
                {
                    if (button.Name == "holdDressingButton")
                    {
                        velociWrap.HoldDressing();
                    }
                    else if (button.Name == "holdLettuceButton")
                    {
                        velociWrap.HoldLettuce();
                    }
                    else
                    {
                        velociWrap.HoldCheese();
                    }
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is VelociWrap wrap)
                {
                    if (button.Name == "holdDressingButton")
                    {
                        wrap.HoldDressing();
                    }
                    else if (button.Name == "holdLettuceButton")
                    {
                        wrap.HoldLettuce();
                    }
                    else
                    {
                        wrap.HoldCheese();
                    }
                }
            }
        }

        #endregion

        #region Remove all Buttons

        // Removes all current special buttons
        private void RemoveAllSpecialButtons()
        {
            while (CustomizeGrid.Children.Count > 0)
            {
                CustomizeGrid.Children.RemoveAt(0);
            }
        }

        #endregion

        #region Navigation Event Handlers

        // Returns to the MenuCategorySelection screen when clicked.
        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new MenuCategorySelection());
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }

        private void DoneButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo)
                {
                    NavigationService?.Navigate(new CustomizeCombo());
                }
                else if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Entree)
                {
                    NavigationService?.Navigate(new MenuCategorySelection());
                }
            }
        }

        #endregion
    }
}
