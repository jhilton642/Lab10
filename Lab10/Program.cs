using System;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Shoe shoe1 = new Shoe(11, "white", "Vans");
            Pants pants1 = new Pants(32, "Jeans", "blue");
            Shirt shirt1 = new Shirt("medium", "red", "t-shirt");
            Console.WriteLine("Today when i got dressed i decided to wear: ");
            Console.WriteLine("SHOES " + shoe1);
            Console.WriteLine("PANTS " + pants1);
            Console.WriteLine("SHIRT " + shirt1);
        }
    }
}
