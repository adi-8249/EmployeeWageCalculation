using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWagecalculation
{
    public class EmpWageArray
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private int numOfCompany = 0;
        private CompanyEmployeeWage[] companyEmployeeWageArray;

        public EmpWageArray()
        {
            this.companyEmployeeWageArray = new CompanyEmployeeWage[5];
        }
        public void addCompanyEmpWage(string company,int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmployeeWageArray[this.numOfCompany]= new CompanyEmployeeWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth);
            numOfCompany++;
        }
        public void computeEmpWage()
        {
            for(int i = 0; i < numOfCompany; i++)
            {
                companyEmployeeWageArray[i].setTotalEmpWage(this.computeEmpWage(this.companyEmployeeWageArray[i]));
                Console.WriteLine(this.companyEmployeeWageArray[i].toString());
            }
        }
        private int computeEmpWage(CompanyEmployeeWage companyempwage)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalWorkingDays = 0;


            //computation using whileloop
            while (totalEmpHrs <= companyempwage.maxHoursPerMonth && totalWorkingDays < companyempwage.numOfWorkingDays) 
            {
                totalWorkingDays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
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
                totalEmpHrs = totalEmpHrs + empHrs;
                Console.WriteLine("Days:" + totalWorkingDays + " emphrs: " + empHrs);
            }
            return totalEmpHrs * companyempwage.empRatePerHour;
        }
    }
}

    
