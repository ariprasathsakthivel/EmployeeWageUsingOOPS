using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageUsingOOPS
{
    public class EmployeeWage : IComputeEmpWage
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        private List<CompanyEmpWage> companyList = new List<CompanyEmpWage>();

        public EmployeeWage()
        {
            this.companyList = new List<CompanyEmpWage>();
        }

        public void AddCompanyEmpWage(string companyName, int empRatePerHour, int numOfWorkingDays, int maxHrsInMonth)
        {
            CompanyEmpWage company = new CompanyEmpWage(companyName, empRatePerHour, numOfWorkingDays, maxHrsInMonth);
            this.companyList.Add(company);
        }

        public void computeEmpWage()
        {
            foreach (var companyEmpWage in this.companyList)
            {
                companyEmpWage.setTotalEmpWage(this.EmpCheck(companyEmpWage));
                Console.WriteLine(companyEmpWage.toString());
            }
        }
        public int EmpCheck(CompanyEmpWage company)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            while (totalEmpHrs <= company.maxHoursPerMonth && totalWorkingDays < company.numOfWorkingDays)
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
                Console.WriteLine("Days#: " + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            return totalEmpHrs * company.empRatePerHour;
        }
    }
}
