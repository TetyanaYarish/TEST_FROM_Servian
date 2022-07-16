using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("SpicyChicken!");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Spicy");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Chicken");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
