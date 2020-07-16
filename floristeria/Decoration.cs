using System;

namespace floristeria
{
    public class Decoration
    {
        private string _material;
        private string[] materialList = new string[]{"wood", "plastic"};
        public string material { get; }
        /*public void SetMaterial(materialType type)
        {
            _material = materialList[parseInt(type)];
        }

        public enum materialType{
            wood = 0,
            plastic = 1
        }*/
    }
}