﻿using System;

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
        }
    }
}
