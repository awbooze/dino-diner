using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        public MenuCategorySelection()
        {
            InitializeComponent();
        }

        public void Button_Click(object sender, RoutedEventArgs args)
        {
            Button buttonClicked = sender as Button;
            if (buttonClicked.Name == "ComboButton")
            {
                NavigationService.Navigate(new ComboSelection());
            }
            else if (buttonClicked.Name == "EntreeButton")
            {
                NavigationService.Navigate(new EntreeSelection());
            }
            else if (buttonClicked.Name == "SideButton")
            {
                throw new NotImplementedException();
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
