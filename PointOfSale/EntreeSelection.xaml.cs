﻿/*  EntreeSelection.xaml.cs
*   Author: Andrew Booze
*/

using DinoDiner.Menu;
using System;
using System.Windows;
using System.Windows.Controls;
using Menu = DinoDiner.Menu.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// The constructor for this page. Adds a button for each entree.
        /// </summary>
        public EntreeSelection()
        {
            InitializeComponent();

            // Adds buttons for each entree to the menu programatically.
            Menu menu = new Menu();
            int x = 0;
            int y = 0;

            foreach (Entree entree in menu.AvailableEntrees)
            {
                TextBlock textBlock = new TextBlock
                {
                    Text = entree.ToString(),
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                };

                Button button = new Button
                {
                    Content = textBlock,
                    Name = App.CreateValidIdString(entree.ToString())
                };

                button.SetValue(Grid.ColumnProperty, x++);
                button.SetValue(Grid.RowProperty, y);

                if (x >= 3)
                {
                    y++;
                    x = 0;
                }

                button.Click += new RoutedEventHandler(Button_Click);
                EntreeGrid.Children.Add(button);
            }
        }

        // Performs any actions necessary when an entree button is clicked
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}