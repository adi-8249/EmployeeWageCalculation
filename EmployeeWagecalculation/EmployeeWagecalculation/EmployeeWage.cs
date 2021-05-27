using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWagecalculation
{
    public class EmployeeWage
    {
        const int IS_PRESENT = 1;
        const int EMP_WAGE_PER_hour = 20;
        const int IS_PART_TIME = 1;
        const int IS_FULL_TIME = 2;
        const int Total_working_days = 2;

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
                Console.WriteLine($"employee workinghour perday:{empworkinghrsperday}");

            }
            else
            {
                empworkinghrsperday = 0;
                Console.WriteLine($"employee workinghrperday:{empworkinghrsperday}");

            }
            TotalWorkingWagePerDay = empworkinghrsperday * EMP_WAGE_PER_hour;
            Console.WriteLine($"employee fullwage:{TotalWorkingWagePerDay}");
        }
        public void PartTimeWage()
        {
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
            Console.WriteLine("Employee Wage : " + empWagePerDay);
        }
        public void EmpWageinswitch()
        {
            int empWorkingHoursPerDay = 0;
            int empWagePerDay = 0;

            Random random = new Random();

            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case IS_PART_TIME:
                    empWorkingHoursPerDay = 4;
                    break;
                case IS_FULL_TIME:
                    empWorkingHoursPerDay = 8;
                    break;
                default:
                    empWorkingHoursPerDay = 0;
                    break;
            }

            empWagePerDay = empWorkingHoursPerDay * EMP_WAGE_PER_hour;
            Console.WriteLine("Employee Wage : " + empWagePerDay);
        }
        public void EmpWagePerMonth()
        {
            int empHrs = 0;
            int empWages = 0;
            int totalEmpWage = 0;
            for (int day = 0; day < Total_working_days; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWages = empHrs * EMP_WAGE_PER_hour;
                totalEmpWage += empWages;
                Console.WriteLine("emp wage: " + empWages);
            }
            Console.WriteLine("total emp wage:" + totalEmpWage);
        }
    }

}
