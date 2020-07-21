using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist_WPF.Models
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
