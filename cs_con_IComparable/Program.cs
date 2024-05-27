using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_IComparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees =
            {
                new Employee() {
                    EmployeeID = 2,
                    EmployeeName = "Second Employee",
                    Designation = "Developer"
                },
                new Employee() { 
                    EmployeeID = 1, 
                    EmployeeName = "First Employee", 
                    Designation = "Manager"
                },
                new Employee() {
                    EmployeeID = 4,
                    EmployeeName = "Fourth Employee",
                    Designation = "Developer"
                },
                new Employee() {
                    EmployeeID = 5,
                    EmployeeName = "Fifth Employee",
                    Designation = "Accountant"
                },
                new Employee() {
                    EmployeeID = 3,
                    EmployeeName = "Third Employee",
                    Designation = "Clerk"
                }
            };

            foreach(Employee emp in employees)
            {
                Console.WriteLine($"{emp.EmployeeID} {emp.EmployeeName}\t{emp.Designation}");
            }
            Console.WriteLine();

            Array.Sort(employees);          // interally calling CompareTo() method for each of the objects in the array

            Console.WriteLine("--- after sorting");
            foreach (Employee emp in employees)
            {
                Console.WriteLine($"{emp.EmployeeID} {emp.EmployeeName}\t{emp.Designation}");
            }
            Console.WriteLine();
        }
    }
}
