using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWagecalculation
{
    public class EmployeeWage
    {
        const int IS_PRESENT = 1;
        const int EMP_WAGE_PER_hour = 20;
        
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
            TotalWorkingWagePerDay = empworkinghrsperday * EMP_WAGE_PER_hour;
            Console.WriteLine($"empfullwage:{TotalWorkingWagePerDay}");
        }
        public void PartTimeWage()
        {
            int IS_PART_TIME = 1;
            int IS_FULL_TIME = 2;

            int empWorkingHoursPerDay = 0;
            int empWagePerDay = 0;

            Random random = new Random();

            int empCheck = random.Next(0, 3);

            if (empCheck == IS_PART_TIME)
            {
                empWorkingHoursPerDay = 4;
            }
            else if (empCheck == IS_FULL_TIME)
            {
                empWorkingHoursPerDay = 8;
            }
            else
            {
                empWorkingHoursPerDay = 0;
            }
            empWagePerDay = empWorkingHoursPerDay * EMP_WAGE_PER_hour;
            Console.WriteLine("Emp Wage : " + empWagePerDay);
        }
    }

}
