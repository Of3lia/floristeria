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

namespace Florist_WPF.Views
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class ItemPage : Page
    {
        public ItemPage()
        {
            InitializeComponent();
        }

        private void PreviousItemButton_Click(object sender, RoutedEventArgs e)
        {
            ItemPage itemPage = new ItemPage();
            this.NavigationService.Navigate(itemPage);
        }

        private void NextItemButton_Click(object sender, RoutedEventArgs e)
        {
            ItemPage itemPage = new ItemPage();
            this.NavigationService.Navigate(itemPage);
        }

        private void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Home home = new Home();
            this.NavigationService.Navigate(home);
        }
    }
}
