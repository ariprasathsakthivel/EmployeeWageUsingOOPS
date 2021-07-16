using System;

namespace EmployeeWageUsingOOPS
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            EmployeeWage employee1 = new EmployeeWage();
            employee1.AddCompanyEmpWage("DMART", 100, 2, 150);
            employee1.AddCompanyEmpWage("RELIANCE", 200, 5, 200);
            employee1.computeEmpWage();
        }
    }
}
