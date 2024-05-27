using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_ValueTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaration & implicit instantiation
            int i = 10000;

            // Declaration & implicit instantiation
            Employee emp1, emp2;                

            // Initialization of the data members
            emp1.EmployeeId = 10;
            emp1.EmployeeName = "First Employee";
            emp1.Salary = 10500M;                   // emp1.Salary = (decimal)10500;
            emp1.Designation = Designations.CEO;

            emp2.EmployeeId = 20;
            emp2.EmployeeName = "Second Employee";
            emp2.Salary = 2000M;
            emp2.Designation = Designations.Developer;

            // Declaration, Explicit Instantiation, Initialization of data members
            Employee emp3 
                = new Employee()   
                {
                    EmployeeId = 30,
                    EmployeeName = "Third Employee",
                    Salary = 4500.50M,
                    Designation = Designations.Manager
                };

            Console.WriteLine(i);
            Console.WriteLine(emp1.GetType());        
            Console.WriteLine();

            Console.WriteLine("Employee #1 properties:");
            Console.WriteLine("  ID: {0}", emp1.EmployeeId);
            Console.WriteLine("  Name: {0}", emp1.EmployeeName);
            Console.WriteLine("  Salary: {0}", emp1.Salary);
            Console.WriteLine("  Designation: {0}", emp1.Designation);

            Console.WriteLine();
            Console.WriteLine("Employee #2 properties:");
            Console.WriteLine(emp2);        // same as: Console.WriteLine( emp2.ToString() );
            emp2.Work();

            Console.WriteLine();
            Console.WriteLine("Employee #3 properties:");
            Console.WriteLine(emp3);        // same as: Console.WriteLine( emp3.ToString() );
            Console.WriteLine(emp3.ToString());
            Console.WriteLine(emp3.GetType());
            emp3.Work();

            Console.WriteLine();
            Console.WriteLine("All employees belong to: {0}", Employee.CompanyName);
        }
    }
}
