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
        // Private backing variable.
        bool shouldChangeCombo = false;

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
            }
        }

        /// <summary>
        /// Another constructor for this page. Allows me to determine whether this is from a combo or a regular page.
        /// </summary>
        /// <param name="fromCombo">Whether this page is instantiated from a combo page.</param>
        public SideSelection(bool fromCombo) : this()
        {
            shouldChangeCombo = fromCombo;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order order)
            {
                CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += SideSelection_CurrentChanged;

                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    // Assign correct buttons if created because of the user clicking on a side
                    UpdateRadioButtons(side);
                }
            }
        }

        private void SideSelection_CurrentChanged(object sender, EventArgs e)
        {
            if (DataContext is Order order)
            {
                CollectionViewSource.GetDefaultView(order.Items).CurrentChanged += SideSelection_CurrentChanged;

                if (CollectionViewSource.GetDefaultView(order.Items).CurrentItem is Side side)
                {
                    // Assign correct buttons if created because of the user clicking on a side
                    UpdateRadioButtons(side);
                }
            }
        }

        // Change radio buttons to correct size
        private void UpdateRadioButtons(Side side)
        {
            RadioButton smallRadio = SizeGrid.Children[0] as RadioButton;
            RadioButton mediumRadio = SizeGrid.Children[1] as RadioButton;
            RadioButton largeRadio = SizeGrid.Children[2] as RadioButton;

            if (side.Size == Menu.Size.Small)
            {
                smallRadio.IsChecked = true;
            }
            else if (side.Size == Menu.Size.Medium)
            {
                mediumRadio.IsChecked = true;
            }
            else
            {
                largeRadio.IsChecked = true;
            }
        }

        // Performs any action required by clicking on one of the sides
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender is Button button && DataContext is Order order)
            {
                Side side;
                if (button.Name == App.CreateValidIdString(new Fryceritops().ToString()))
                {
                    side = new Fryceritops();
                }
                else if (button.Name == App.CreateValidIdString(new Triceritots().ToString()))
                {
                    side = new Triceritots();
                }
                else if (button.Name == App.CreateValidIdString(new MeteorMacAndCheese().ToString()))
                {
                    side = new MeteorMacAndCheese();
                }
                else    // Mezzorella Sticks
                {
                    side = new MezzorellaSticks();
                }

                // Change side to correct size after adding item to order
                RadioButton mediumRadio = SizeGrid.Children[1] as RadioButton;
                RadioButton largeRadio = SizeGrid.Children[2] as RadioButton;

                if ((bool)mediumRadio.IsChecked)
                {
                    side.Size = Menu.Size.Medium;
                }
                else if ((bool)largeRadio.IsChecked)
                {
                    side.Size = Menu.Size.Large;
                }

                if (shouldChangeCombo && 
                    CollectionViewSource.GetDefaultView(order.Items).CurrentItem is CretaceousCombo combo)
                {
                    combo.Side = side;
                }
                else
                {
                    // Add the drink to the order
                    order.Items.Add(side);

                    // Focus on the new drink
                    CollectionViewSource.GetDefaultView(order.Items).MoveCurrentToLast();
                }
            }
        }

        // Changes side size when appropriate.
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
