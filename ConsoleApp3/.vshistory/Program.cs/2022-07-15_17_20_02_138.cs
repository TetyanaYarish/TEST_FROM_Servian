using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int income = 180000;
            double tax = 0;
            double anualIncome = 0;
            if (income<18201 && income>37000)
            {
                tax = 0.19*income;
                anualIncome = income - tax;
            }
            else if (income < 37001 && income > 87000)
            {
                tax = 0.325 * income;
                anualIncome = income - tax;
            }
            else if (income < 87001 && income > 180000)
            {
                tax = 0.37 * income;
                anualIncome = income - tax;
            }
            else 
            {
                tax = 0.45 * income;
                anualIncome = income - tax;
            }
            Console.WriteLine(anualIncome);
        }
    }
}
