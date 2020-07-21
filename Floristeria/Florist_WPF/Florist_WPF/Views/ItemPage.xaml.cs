using Florist_WPF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public int Iterator { get; set; }

        public void Init()
        {
            Iterator = 0;
            UpdateItem();
        }

        private void UpdateItem()
        {
            var len = FlowerShop.Stock.Count;
            string type = "", price = "", feature = "Feature: ", feature_value = "";

            if (len == 0) // no items in the FlowerShop
            {
                Iterator = -1;
            }
            else
            {
                // to show the items in a loop (1, 2 ... n, 1, 2...)
                if (Iterator <= -1) // previous button (lower limit)
                {
                    Iterator = len-1;
                }
                else if (Iterator >= len) // next button (upper limit)
                {
                    Iterator = 0;
                }

                // finding item type
                var itemType_str = FlowerShop.Stock[Iterator].GetType().ToString();
                if (itemType_str == "Florist_WPF.Models.Tree")
                {
                    type = "Tree";
                    feature = "Height: ";

                    var _tree = (Tree)FlowerShop.Stock[Iterator];
                    price = _tree.Price.ToString();
                    feature_value = _tree.Height.ToString();
                }
                else if (itemType_str == "Florist_WPF.Models.Flower")
                {
                    type = "Flower";
                    feature = "Color: ";

                    var _flower = (Flower)FlowerShop.Stock[Iterator];
                    price = _flower.Price.ToString();
                    feature_value = _flower.Color.ToString();
                }
                else if (itemType_str == "Florist_WPF.Models.Decoration")
                {
                    type = "Decoration";
                    feature = "Material: ";

                    var _deco = (Decoration)FlowerShop.Stock[Iterator];
                    price = _deco.Price.ToString();
                    feature_value = _deco.Material.ToString();
                }

            }
            
            itemIndex.Text = $"{Iterator+1}/{len}";
            itemType.Text = type;
            itemPrice.Text = price;
            itemFeature.Text = feature;
            itemFeature_value.Text = feature_value;
        }

        private void PreviousItemButton_Click(object sender, RoutedEventArgs e)
        {
            Iterator--;
            UpdateItem();
        }

        private void NextItemButton_Click(object sender, RoutedEventArgs e)
        {
            Iterator++;
            UpdateItem();
        }

        private void MainMenuButton_Click(object sender, RoutedEventArgs e)
        {
            Iterator = 0;
            this.NavigationService.GoBack();
        }
    }
}
