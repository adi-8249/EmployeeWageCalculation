using System;

namespace EmployeeWagecalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Calculation");
            EmployeeWage dmart = new EmployeeWage("Dmart", 20, 2, 10);
            EmployeeWage relience = new EmployeeWage("Relience", 10, 4, 20);
            dmart.empWagecompute();
            Console.WriteLine(dmart.toString());
            relience.empWagecompute();
            Console.WriteLine(relience.toString());

            









        }
    }
}
