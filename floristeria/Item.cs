using System;

namespace floristeria
{
	public class Item
	{
		public Item(float price)
		{
			this.Price = price;
		}
		protected float Price { get; set; }
	}
}