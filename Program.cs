using System;

namespace EmployeeWageComputation
{
    class program
    {


        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMART ", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Relience ", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}