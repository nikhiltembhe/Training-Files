using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_IEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company objCompany = new Company("Microsoft");

            objCompany.AddEmployee(
                new Employee() 
                { 
                    EmployeeID = 1, 
                    EmployeeName = "First Employee", 
                    BranchName = "Mumbai"
                });
            objCompany.AddEmployee(new Employee { EmployeeID = 2, EmployeeName = "Second Employee", BranchName = "Bangalore" });
            objCompany.AddEmployee(new Employee { EmployeeID = 3, EmployeeName = "Third Employee", BranchName = "Mumbai" });
            objCompany.AddEmployee(new Employee { EmployeeID = 4, EmployeeName = "Fourth Employee", BranchName = "Delhi" });
            objCompany.AddEmployee(new Employee { EmployeeID = 5, EmployeeName = "Fifth Employee", BranchName = "Mumbai" });

            objCompany.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("--- Iterating through the Aggregated Collection using IEnumerator members");
            objCompany.Reset();
            while (objCompany.MoveNext())
            {
                Employee emp = objCompany.Current as Employee;
                Console.WriteLine($"{emp.EmployeeID} {emp.EmployeeName} {emp.BranchName}");
            }
            Console.WriteLine();


            Employee empThird = objCompany[3];          // idToFind == 3
            if (empThird != null)
            {
                Console.WriteLine($"ID and Name of the searched employee: {empThird.EmployeeID} {empThird.EmployeeName}");
            }
            else
            {
                Console.WriteLine("Sorry!  Did not find the employee");
            }
            Console.WriteLine();


            System.Collections.ArrayList empFound = objCompany["Mumbai"];
            if (empFound != null || empFound.Count != 0)
            {
                Console.WriteLine("Employees of the Branch: MUMBAI");
                foreach (Employee emp in empFound)
                {
                    Console.WriteLine("{0} {1} {2}", emp.EmployeeID, emp.EmployeeName, emp.BranchName);
                }
            }
            else
            {
                Console.WriteLine("No employees were found in the branch MUMBAI");
            }
        }
    }
}
