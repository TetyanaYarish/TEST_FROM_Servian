using System;

namespace ConsoleApp3
{

   public class Program
    {
        public static string CalculateTax(float income)
        {
            double tax = 0;
            while (income>18201)
            {

            }
            if (income<18200)
            {
                tax = 0;
            }
            else if(income>18201 && income<37001)
            {
                tax =income- 0.325 * income;
            }

            else if (income >= 37001 && income < 87001)
            {
                tax = income - 0.37 * income;
            }
            else if (income >= 87001 && income < 180001)
            {
                tax = income - 0.45 * income;
            }
            tax = Math.Round(tax, 2);
            return tax.ToString();
        }

        static void Main(string[] args)
        {
           CalculateTax(37000);
        }
    }
}
