using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageUsingOOPS
{
    class EmployeeWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        int EMP_RATE_PER_HOUR;
        int NUM_OF_WORKING_DAYS;
        int MAX_HRS_IN_MONTH;
        string COMPANY_NAME;
        public EmployeeWage(string companyName, int empRatePerHour, int numOfWorkingDays, int maxHrsInMonth)
        {
            this.EMP_RATE_PER_HOUR = empRatePerHour;
            this.NUM_OF_WORKING_DAYS = numOfWorkingDays;
            this.MAX_HRS_IN_MONTH = maxHrsInMonth;
            this.COMPANY_NAME = companyName;
        }
        public void EmpCheck()
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= this.MAX_HRS_IN_MONTH && totalWorkingDays <= this.NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Days#:" + totalWorkingDays + "Emp Hrs : " + empHrs);
            }
            int totalEmpwage = totalEmpHrs * this.EMP_RATE_PER_HOUR;
            EmpWageBuilder(totalEmpwage);
        }
        public void EmpWageBuilder(int totalEmpwage)
        {
            Console.WriteLine("Total Emp Wage for {0} is {1}", this.COMPANY_NAME, totalEmpwage);
        }
    }
}
