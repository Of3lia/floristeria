using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist_WPF.Models
{
    public class Flower : Item
    {
        public Flower(float price, string color) : base(price)
        {
            this.Color = color;
        }
        public string Color { get; set; }

        public override string ToString()
        {
            return $"Flower (color: {Color}, price: {Price})";
        }
    }
}
