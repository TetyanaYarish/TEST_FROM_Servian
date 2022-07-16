using System;

namespace ConsoleApp3
{

   public class Program
    {
        public static void Print(int min, int max)
        {
            for (int i = min; i <= max; i++)
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

        static void Main(string[] args)
        {
             Print(1,100);
        }
    }
}
