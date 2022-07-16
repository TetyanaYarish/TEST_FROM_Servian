using System;

namespace ConsoleApp3
{

   public class Program
    {
        public static string CalculateTax(float income)
        {
            double tax = 0;
            double tax = 0;
            float income1 = 0;
            //while (income>18201)
            //{

            //}
            if (income>180000)
            {
                income1 = income - 180000;
                tax=income1* 0.45;
                income = income - income1;
            }
            if (income > 870000 && income<=180000)
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
                tax = tax + income1 * 0.325;
                income = income - income1;
            }
            else
            {
                tax = tax;
            }
            tax = Math.Round(tax, 2);
            return tax.ToString();
        }

        static void Main(string[] args)
        {
           Console.WriteLine(CalculateTax(37001));
        }
    }
}
