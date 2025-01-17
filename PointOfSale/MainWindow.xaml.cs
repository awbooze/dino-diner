﻿/*  MainWindow.xaml.cs
*   Modified by: Andrew Booze
*/

using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// The constructor for this page. Intitializes all components defined in MainWindow.xaml.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            
            // Make sure the OrderControl can access the NavigationService of the frame.
            OrderControl.NavigationService = OrderUi.NavigationService;
        }

        /// <summary>
        /// Event handler called when a page has loaded within the frame.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderUi_LoadCompleted(object sender, NavigationEventArgs e)
        {
            PassOnDataContext();
        }

        /// <summary>
        /// Event handler called when the Data Context for the frame (the order object) changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderUi_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            PassOnDataContext();
        }

        /// <summary>
        /// Pass the data context to the contents of the Frame, bypassing the sandbox of the frame in order
        /// to get data through.
        /// </summary>
        private void PassOnDataContext()
        {
            if (OrderUi.Content is Page page)
            {
                page.DataContext = OrderUi.DataContext;
            }
        }
    }
}
