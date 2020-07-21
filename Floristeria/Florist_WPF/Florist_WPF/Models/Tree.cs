using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Florist_WPF.Models
{
	public class Tree : Item
	{
		public Tree(float price, float height) : base(price)
		{
			this.Height = height;
		}

		public float Height { get; set; }

		public override string ToString()
		{
			return $"Tree (Height: {Height}, Price: {Price})";
		}
	}
}
