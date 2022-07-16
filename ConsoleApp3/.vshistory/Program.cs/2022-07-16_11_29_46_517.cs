using System;

namespace ConsoleApp3
{

   public class Program
    {
        public static string CalculateTax(float income)
        {
            double tax = 0;
            double tax1 = 0;
            double income1 = 0;
            //while (income>18201)
            //{

            //}
            if (income>180000)
            {
                income1 = income - 180000;
                tax=income1* 0.45;
            }
            if (income > 870000 && income<=180000)
            {
                income1 = income - 870000;
                tax = tax1+income1 * 0.37;
            }
            tax = Math.Round(tax, 2);
            return tax.ToString();
        }

        static void Main(string[] args)
        {
           CalculateTax(180000);
        }
    }
}
