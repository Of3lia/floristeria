using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist_WPF.Models
{
    class FlowerShop
    {
        public FlowerShop(string name)
        {
            Name = name;
            Stock = new List<Item>();
        }
        public string Name { get; set; }

        public static List<Item> Stock;
    }
}
