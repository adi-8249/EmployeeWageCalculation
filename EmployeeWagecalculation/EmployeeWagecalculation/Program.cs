using System;

namespace EmployeeWagecalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Calculation");

            EmpWageArray empwagearray = new EmpWageArray();

            empwagearray.addCompanyEmpWage("Dmart", 15, 2, 8);
            empwagearray.addCompanyEmpWage("Relience", 10, 2, 8);
            empwagearray.computeEmpWage();
        }
    }
}
