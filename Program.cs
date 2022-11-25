using System;

namespace EmpWageComputation
{
    class program
    {


        static void Main(string[] args)
        {
            EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
            empWageBuilderArray.addCompanyEmpWage("Wipro ", 20, 2, 10);
            empWageBuilderArray.addCompanyEmpWage("DXC ", 10, 4, 20);
            empWageBuilderArray.computeEmpWage();

        }
    }
}