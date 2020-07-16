using System;

namespace floristeria
{
    public class Decoration : Item
    {
        public Decoration(float price, MaterialType material): base(price)
        {
            this.Material = material;
        }
        
        public MaterialType Material { get; set;}

        public override string ToString()
        {
            return $"Decoration (Material: {Material}, price: {Price})";
        }

    }

    public enum MaterialType{
        wood,
        plastic
    }
}