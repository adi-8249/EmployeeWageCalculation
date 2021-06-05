using System;

namespace EmployeeWagecalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Calculation");
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.CalculateEmployeeAttendance();
            employeeWage.CalculateDaillyEmpWage();
            employeeWage.PartTimeWage();
            employeeWage.EmpWageinswitch();
            employeeWage.EmpWagePerMonth();
            employeeWage.EmpWageinCondition();
            EmployeeWage.CalculationEmpWage();
            EmployeeWage.EmpWageMultipleCompany("Dmart", 20, 2, 10);
            EmployeeWage.EmpWageMultipleCompany("Relience", 10,4,20);







        }
    }
}
