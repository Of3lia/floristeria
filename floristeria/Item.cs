using System;

namespace floristeria
{
	public abstract class Item
	{
		public Item(float price)
		{
			this.Price = price;
		}
		public float Price { get; set; }

		public override string ToString()
        {
            return $"Item (price: {Price})";
        }
	}
}