using System;

namespace floristeria
{
    public class Decoration : Item
    {
        public Decoration(float price, MaterialType material): base(price)
        {
            this.Material = material;
        }
        //private string[] materialList = new string[]{"wood", "plastic"};  // para mas adelante
        public MaterialType Material { get; set;}

        public override string ToString()
        {
            return $"Decoration (Material: {Material}, price: {Price})";
        }

    }

    public enum MaterialType{
        wood = 0,
        plastic = 1
    }
}