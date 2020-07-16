using System;

namespace floristeria
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new Tree(2.5F, 3.4F);
            Console.WriteLine(tree.ToString());

            var flower = new Flower(1.2F, "yellow");
            Console.WriteLine(flower.ToString());

            /*var deco = new Flower(2.5F, MaterialType.wood); // aun no esta listo
            Console.WriteLine(deco.ToString());*/
        }
    }
}
