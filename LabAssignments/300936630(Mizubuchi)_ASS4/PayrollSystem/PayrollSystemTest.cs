// Fig. 12.9: PayrollSystemTest.cs
// Employee hierarchy test app.
using System;
using System.Collections.Generic;
using System.Linq;

/**
 * Question 3 										[5 marks]
 * Update the PayrollSytem by using LINQ to map the List<Employee> in 
 * to a list of anonymous objects in which each object contains an Employee’s name
 * and earnings. When a BasePlusCommissionEmployee is encountered, give a 10% base-salary
 * increase without modifying the original BasePlusCommissionEmployee object. 
 * Display the names and earnings.
 */

public static class EmployeeExtensionMethods
{
    public static decimal GetEarnings(this Employee employee)
    {
        // check employee type here
        if (employee.GetType() == typeof(BasePlusCommissionEmployee))
        {
            BasePlusCommissionEmployee bpcEmployee = ((BasePlusCommissionEmployee)employee);

            // change actual base salary
            //bpcEmployee.BaseSalary = bpcEmployee.BaseSalary * 1.1m;
            //return bpcEmployee.Earnings();

            // calculate earnings
            decimal earnings = bpcEmployee.BaseSalary * 1.1m + bpcEmployee.CommissionRate * bpcEmployee.GrossSales;

            return earnings;    

        }
        else
        {
            return employee.Earnings();
        }
    }

}

class PayrollSystemTest
{
    static void Main()
    {
        // create derived-class objects
        var salariedEmployee = new SalariedEmployee("John", "Smith",
            "111-11-1111", 800.00M);
        var hourlyEmployee = new HourlyEmployee("Karen", "Price",
           "222-22-2222", 16.75M, 40.0M);
        var commissionEmployee = new CommissionEmployee("Sue", "Jones",
           "333-33-3333", 10000.00M, .06M);
        var basePlusCommissionEmployee =
           new BasePlusCommissionEmployee("Bob", "Lewis",
           "444-44-4444", 5000.00M, .04M, 300.00M);

        // create List<Employee> and initialize with employee objects
        var employees = new List<Employee>() {salariedEmployee,
         hourlyEmployee, commissionEmployee, basePlusCommissionEmployee};

        // display all the employee information
        Console.WriteLine("--- BEFORE ---");
        foreach (var emp in employees) Console.WriteLine(emp);
        Console.WriteLine();

        // create the list of anonymous objects which has name and earnings;
        var employeeWithEarnings = from e in employees
                                   select new
                                   {
                                       NAME = $"{e.FirstName} {e.LastName}",
                                       EARNINGS = e.GetEarnings() // extention method
                                   };


        // display
        Console.WriteLine("--- NAME AND EARNINGS ---");
        foreach (var emp in employeeWithEarnings) Console.WriteLine(emp);
        Console.WriteLine();

        // see if base salary changed
        Console.WriteLine("--- AFTER ---");
        foreach (var emp in employees) Console.WriteLine(emp);
        Console.WriteLine();

    }

}