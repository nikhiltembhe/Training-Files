using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaration 
            Employee emp1;

            // Explicit Instantiation is needed for Reference Types
            emp1 = new Employee();

            // Initialization of the data members
            emp1.EmployeeId = 10;
            emp1.EmployeeName = "First Employee";
            emp1.Salary = 10500M;
            emp1.Designation = Designations.CEO;

            Employee emp2 = new Employee();
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

            // Derived Class object
            DeveloperEmployee developer
                = new DeveloperEmployee()
                {
                    EmployeeId = 40,
                    EmployeeName = "My Developer Employee",
                    Salary = 6500M,
                    LaptopSerialNumber = "IBM Sl #0007"         // custom derived class attribute
                };

            Console.WriteLine("Employee #1 properties:");
            Console.WriteLine(emp1);
            emp1.Work();

            Console.WriteLine();
            Console.WriteLine("Employee #2 properties:");
            Console.WriteLine(emp2);
            emp2.Work();

            Console.WriteLine();
            Console.WriteLine("Employee #3 properties:");
            Console.WriteLine(emp3.ToString());
            emp3.Work();


            Console.WriteLine();
            Console.WriteLine("Developer Employee properties:");
            Console.WriteLine(developer);
            developer.Work();


            Console.WriteLine();
            Console.WriteLine("All employees belong to: {0}", Employee.CompanyName);
        }
    }
}
