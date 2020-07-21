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
using Florist_WPF.Views;

namespace Florist_WPF
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Home()
        {
            InitializeComponent();
            ItemPage = new ItemPage();
            addProductsPage = new AddProducts();
        }

        private ItemPage ItemPage {get;}
        private AddProducts addProductsPage;

        private void AddProductsButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(addProductsPage);
        }

        private void ItemPageButton_Click(object sender, RoutedEventArgs e)
        {
            ItemPage.Init();
            this.NavigationService.Navigate(ItemPage);
        }
    }

    //private void AddProductsButton_Click(object sender, RoutedEventArgs e)
    //{
    //    var window = new AddProducts();
    //    this.Content = window;
    //}
}
