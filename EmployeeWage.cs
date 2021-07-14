using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageUsingOOPS
{
    class EmployeeWage
    {
        public static int IS_FULL_TIME = 1;
        public void EmpCheck()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
