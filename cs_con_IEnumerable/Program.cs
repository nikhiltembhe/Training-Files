using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_IEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company objCompany = new Company("Microsoft");

            objCompany.AddEmployee(new Employee { EmployeeID = 1, EmployeeName = "First Employee", BranchName = "Mumbai"});
            objCompany.AddEmployee(new Employee { EmployeeID = 2, EmployeeName = "Second Employee", BranchName = "Bangalore" });
            objCompany.AddEmployee(new Employee { EmployeeID = 3, EmployeeName = "Third Employee", BranchName = "Mumbai" });
            objCompany.AddEmployee(new Employee { EmployeeID = 4, EmployeeName = "Fourth Employee", BranchName = "Delhi" });
            objCompany.AddEmployee(new Employee { EmployeeID = 5, EmployeeName = "Fifth Employee", BranchName = "Mumbai" });

            objCompany.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("--- Iterating through the Aggregated Collection using IEnumerable members");
            foreach (Employee emp in objCompany)
            {
                Console.WriteLine($"{emp.EmployeeID} {emp.EmployeeName} {emp.BranchName}");
            }
        }
    }
}
