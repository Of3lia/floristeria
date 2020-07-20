using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for AddProducts.xaml
    /// </summary>
    public partial class AddProducts : Page
    {
        public AddProducts()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("Hola");
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            TreeType.IsChecked = true;
            PriceTextBox.Text = "";
        }

        private void PriceTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Validates Only Numerical Values
            Regex regex = new Regex("([^0-9.])");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            string price = PriceTextBox.Text.Replace(" ", "");

            int dot = 0;
            for(int i = 0; i < price.Length; i++)
            {
                if(PriceTextBox.Text[i] == '.')
                {
                    dot++;
                }
            }
            if (dot > 1 || price == "." || price == "") { MessageBox.Show("Invalid Price Value"); }
            else { MessageBox.Show(price); }
        }
    }
}
