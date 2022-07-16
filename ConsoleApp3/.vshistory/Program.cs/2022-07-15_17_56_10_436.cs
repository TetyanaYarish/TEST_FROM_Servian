using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int salary = 0;
            double tax = 0;
            double anualIncome = 0;
            if (salary<18201 && salary>37000)
            {
                tax = 0.19*salary;
                anualIncome = salary - tax;
            }
            else if (salary < 37001 && salary > 87000)
            {
                tax = 0.325 * salary;
                anualIncome = salary - tax;
            }
            else if (salary < 87001 && salary > 180000)
            {
                tax = 0.37 * salary;
                anualIncome = salary - tax;
            }
            else 
            {
                tax = 0.45 * salary;
                anualIncome = salary - tax;
            }
        }
    }
}
