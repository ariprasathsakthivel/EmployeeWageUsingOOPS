using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWageUsingOOPS
{
    public interface IComputeEmpWage
    {
        void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        void computeEmpWage();
    }
}
