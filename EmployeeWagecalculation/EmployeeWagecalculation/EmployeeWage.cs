using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWagecalculation
{
    public class EmployeeWage
    {
        const int IS_PRESENT = 1;
        public void CalculateEmployeeAttendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
                Console.WriteLine("employee is present");
            else
                Console.WriteLine("employee is absent");

        }
        public void CalculateDaillyEmpWage()
        {
            int TotalWorkingWagePerDay = 0;
            int IS_FULLTIME = 1;
            int WAGE_PER_HOUR = 20;
            int empworkinghrsperday = 0;
            int wagepertotalhours = 0;
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == 1)
            {
                empworkinghrsperday = 8;
                Console.WriteLine($"empworkinghrperday:{empworkinghrsperday}");

            }
            else
            {
                empworkinghrsperday = 0;
                Console.WriteLine($"empworkinghrperday:{empworkinghrsperday}");

            }
            TotalWorkingWagePerDay = empworkinghrsperday * WAGE_PER_HOUR;
            Console.WriteLine($"empfullwage:{TotalWorkingWagePerDay}");
        }
    }

}
