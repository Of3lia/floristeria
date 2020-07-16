using System;

public class Tree : Item
{
	public Tree(float price, float height): base(price)
	{
		this.Height = height;
	}

	private float Height { get; set; }
}
