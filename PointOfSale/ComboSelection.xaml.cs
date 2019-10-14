using DinoDiner.Menu;
using System.Windows;
using System.Windows.Controls;
using Menu = DinoDiner.Menu.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();

            // Adds buttons for each combo to the menu programattically.
            Menu menu = new Menu();
            int x = 0;
            int y = 0;

            foreach (CretaceousCombo combo in menu.AvailableCombos)
            {
                TextBlock textBlock = new TextBlock
                {
                    Text = combo.ToString(),
                    TextWrapping = TextWrapping.WrapWithOverflow,
                    TextAlignment = TextAlignment.Center
                };

                Button button = new Button
                {
                    Content = textBlock,
                    Name = App.CreateValidIdString(combo.Entree.ToString())
                };

                button.SetValue(Grid.ColumnProperty, x++);
                button.SetValue(Grid.RowProperty, y);

                if (x >= 3)
                {
                    y++;
                    x = 0;
                }

                button.Click += new RoutedEventHandler(Button_Click);
                ComboGrid.Children.Add(button);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Placeholder for adding combo information later.
            Button buttonClicked = sender as Button;

            // No matter what, go to the customize combo screen
            NavigationService.Navigate(new CustomizeCombo());
        }
    }
}
