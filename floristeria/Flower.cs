using System;

namespace floristeria
{
    public class Flower : Item
    {
        public Flower(float price, string color): base(price)
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