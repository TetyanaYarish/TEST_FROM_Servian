using System;

namespace ConsoleApp3
{

   public class Program
    {
        public static string CalculateTax(float income)
        {
            double tax = 0;
            float income1 = 0;

            if (income>180000)
            {
                income1 = income - 180000;
                tax=income1* 0.45;
                income = income - income1;
            }
            if (income > 87000 && income<=180000)
            {
                income1 = income - 87000;
                tax = tax+income1 * 0.37;
                income = income - income1;
            }
            if (income > 37000 && income <= 87000)
            {
                income1 = income - 37000;
                tax = tax + income1 * 0.325;
                income = income - income1;
            } 
            if (income > 18200 && income <= 37000)
            {
                income1 = income - 18200;
                tax = tax + income1 * 0.19;
                income = income - income1;
            }

            tax = Math.Round(tax, 2);
            return tax.ToString();
        }
        public static void PrintSpicyChicken(int min, int max)
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
           Console.WriteLine("Tax amout for tis salary: $"+CalculateTax(180001));
           Console.WriteLine("Spicy chicken test\n");
           PrintSpicyChicken(1,100);
            
        }
    }
}
