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
using Florist_WPF.Models;

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
            currentFeaturePanel = HeightFeaturePanel;
        }

        StackPanel currentFeaturePanel;

        string selectedTypeRadioButton = "tree";
        string color = "Red";
        MaterialType material = MaterialType.wood;
        

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            TreeType_Click(sender, e);
            TreeType.IsChecked = true;
            selectedTypeRadioButton = "tree";
            HeightTextBox.Text = "";
            PriceTextBox.Text = "";
            color = "";
            material = MaterialType.wood;
            WoodType.IsChecked = true;
        }

        private void PriceTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Validates Only Numerical Values
            Regex regex = new Regex("([^0-9,.])");
            e.Handled = regex.IsMatch(e.Text);
        }

        #region RadioButtons
        private void TreeType_Click(object sender, RoutedEventArgs e)
        {
            selectedTypeRadioButton = "tree";
            currentFeaturePanel.Visibility = Visibility.Hidden;
            currentFeaturePanel = HeightFeaturePanel;
            currentFeaturePanel.Visibility = Visibility.Visible;
        }

        private void FlowerType_Click(object sender, RoutedEventArgs e)
        {
            selectedTypeRadioButton = "flower";
            currentFeaturePanel.Visibility = Visibility.Hidden;
            currentFeaturePanel = ColorFeaturePanel;
            currentFeaturePanel.Visibility = Visibility.Visible;
        }

        private void DecorationType_Click(object sender, RoutedEventArgs e)
        {
            selectedTypeRadioButton = "decoration";
            currentFeaturePanel.Visibility = Visibility.Hidden;
            currentFeaturePanel = DecorationFeaturePanel;
            currentFeaturePanel.Visibility = Visibility.Visible;

        }

        private void DecorationRadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton _sender = (RadioButton)sender;
            //MessageBox.Show(_sender.Content.ToString());
            if(_sender.Content.ToString() == "Wood") { material = MaterialType.wood; }
            else if(_sender.Content.ToString() == "Plastic") { material = MaterialType.plastic; }
            else { MessageBox.Show("Error on material type"); }
        }

        #endregion

        private void ColorRadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton _sender = (RadioButton)sender;
            color = _sender.Content.ToString();
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            string price = PriceTextBox.Text.Replace(" ", "");

            int dot = 0;
            for (int i = 0; i < price.Length; i++)
            {
                if (price[i] == ',' || price[i] == '.')
                {
                    dot++;
                }
            }
            if (dot > 1 || price == "," || price == "") { MessageBox.Show("Invalid Price Value"); }
            else
            {
                //MessageBox.Show($"Product Added Successfully\n Type: {selectedTypeRadioButton} \n Price:  {price}");
                switch (selectedTypeRadioButton)
                {
                    case "tree":

                        string height = HeightTextBox.Text.Replace(" ", "");
                        int dot2 = 0;
                        for (int i = 0; i < height.Length; i++)
                        {
                            if (height[i] == ',' || price[i] == '.')
                            {
                                dot2++;
                            }
                        }
                        if (dot2 > 1 || height == "," || height == "") { MessageBox.Show("Invalid Height Value"); }
                        else
                        {
                            FlowerShop.Stock.Add(new Tree(float.Parse(price), float.Parse(height)));
                            Tree _tree = (Tree)FlowerShop.Stock[FlowerShop.Stock.Count -1];
                            MessageBox.Show($"Product Added Successfully\nType: {selectedTypeRadioButton}\nPrice: ${_tree.Price.ToString()}\nHeight: {_tree.Height.ToString()}");
                        }
                        //Stock.Add(new Tree(float.Parse(price), float.Parse(feature)));

                        break;
                    case "flower":

                        FlowerShop.Stock.Add(new Flower(float.Parse(price), color));
                        Flower _flower = (Flower)FlowerShop.Stock[FlowerShop.Stock.Count - 1];
                        MessageBox.Show($"Product Added Successfully\nType: {selectedTypeRadioButton}\nPrice: ${_flower.Price.ToString()}\nColor: {_flower.Color.ToString()}");

                        break;
                    case "decoration":

                        FlowerShop.Stock.Add(new Decoration(float.Parse(price), material));
                        Decoration _decoration = (Decoration)FlowerShop.Stock[FlowerShop.Stock.Count - 1];
                        MessageBox.Show($"Product Added Successfully\nType: {selectedTypeRadioButton}\nPrice: ${_decoration.Price.ToString()}\Material: {_decoration.Material.ToString()}");

                        break;
                    default:
                        break;
                }
                this.NavigationService.GoBack();
            }
        }
    }
}
