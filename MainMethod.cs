using System;

namespace EmployeeWageUsingOOPS
{
    class MainMethod
    {
        static void Main(string[] args)
        {
            EmployeeWage employee1 = new EmployeeWage("DMART", 100, 20, 150);
            employee1.EmpCheck();
        }
    }
}
