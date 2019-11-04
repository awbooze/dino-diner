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
                        //ChangeToDinoNuggetsButtons();
                    }
                    else if (combo.Entree is PrehistoricPBJ)
                    {
                        //ChangeToPrehistoricPBJButtons();
                    }
                    else if (combo.Entree is PterodactylWings)
                    {
                        //ChangeToPterodactylWingsButtons();
                    }
                    else if (combo.Entree is SteakosaurusBurger)
                    {
                        //ChangeToSteakosaurusBurgerButtons();
                    }
                    else if (combo.Entree is TRexKingBurger)
                    {
                        //ChangeToTRexKingBurgerButtons();
                    }
                    else if (combo.Entree is VelociWrap)
                    {
                        //ChangeToVelociWrapButtons();
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
                        //ChangeToDinoNuggetsButtons();
                    }
                    else if (entree is PrehistoricPBJ)
                    {
                        //ChangeToPrehistoricPBJButtons();
                    }
                    else if (entree is PterodactylWings)
                    {
                        //ChangeToPterodactylWingsButtons();
                    }
                    else if (entree is SteakosaurusBurger)
                    {
                        //ChangeToSteakosaurusBurgerButtons();
                    }
                    else if (entree is TRexKingBurger)
                    {
                        //ChangeToTRexKingBurgerButtons();
                    }
                    else if (entree is VelociWrap)
                    {
                        //ChangeToVelociWrapButtons();
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
                        //ChangeToDinoNuggetsButtons();
                    }
                    else if (combo.Entree is PrehistoricPBJ)
                    {
                        //ChangeToPrehistoricPBJButtons();
                    }
                    else if (combo.Entree is PterodactylWings)
                    {
                        //ChangeToPterodactylWingsButtons();
                    }
                    else if (combo.Entree is SteakosaurusBurger)
                    {
                        //ChangeToSteakosaurusBurgerButtons();
                    }
                    else if (combo.Entree is TRexKingBurger)
                    {
                        //ChangeToTRexKingBurgerButtons();
                    }
                    else if (combo.Entree is VelociWrap)
                    {
                        //ChangeToVelociWrapButtons();
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
                        //ChangeToDinoNuggetsButtons();
                    }
                    else if (entree is PrehistoricPBJ)
                    {
                        //ChangeToPrehistoricPBJButtons();
                    }
                    else if (entree is PterodactylWings)
                    {
                        //ChangeToPterodactylWingsButtons();
                    }
                    else if (entree is SteakosaurusBurger)
                    {
                        //ChangeToSteakosaurusBurgerButtons();
                    }
                    else if (entree is TRexKingBurger)
                    {
                        //ChangeToTRexKingBurgerButtons();
                    }
                    else if (entree is VelociWrap)
                    {
                        //ChangeToVelociWrapButtons();
                    }
                }
            }
        }

        private void ChangeToBrontowurstButtons()
        {
            RemoveAllSpecialButtons();

            // Add buttons for Water
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

        // Removes all current special buttons
        private void RemoveAllSpecialButtons()
        {
            while (CustomizeGrid.Children.Count > 0)
            {
                CustomizeGrid.Children.RemoveAt(0);
            }
        }

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
    }
}
