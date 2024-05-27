using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_conFW_Destructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1;           // Declare
            Employee emp2 = null;    // Declare & Instantiate

            Employee emp3 = new Employee(3, "Third Employee");
            emp3 = null;

            m();
            Employee emp4 = new Employee(4, "Fourth Employee");
            m();

            Console.WriteLine();
            Console.WriteLine("------ exiting the Main()");
        }

        static void m()
        {
            Employee emp100 = new Employee(100, "Hundredth employee");

            Employee[] empArr = new Employee[3];
            empArr[0] = new Employee(10, "Tenth Employee");
            empArr[1] = new Employee(20, "Twentieth Employee");
            empArr[2] = new Employee(30, "Thirtieth Employee");
        }

    }
}
