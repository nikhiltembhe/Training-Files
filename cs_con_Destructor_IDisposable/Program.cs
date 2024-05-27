using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace cs_con_Destructor_IDisposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // System.Collections.ArrayList list = new System.Collections.ArrayList();
            ArrayList list = new ArrayList();

            // Demo01();

            // Manually the developer calls the Dispose()
            // Demo02();

            // Dispose() is called Automatically 
            Demo03();

            Console.WriteLine();
            Console.WriteLine("------ exiting the MAIN() method");
            Console.WriteLine();
        }

        // BENEFIT:
        //    You can now control how the resource is used within your program.
        private static void Demo02()
        {
            Employee emp10 = new Employee(10, "Some employee");

            emp10.Salary = 2000;
            emp10.Work();

            emp10.Dispose();        // manually called
        }

        private static void Demo03()
        {
            // Resource Managing an object
            // The object will be consumed and visible - disposed on exiting the code block!
            using (Employee emp20 = new Employee(20, "another employee"))
            {
                // Employee emp20 = new Employee(20, "another employee");
                emp20.Salary = 50000;
                emp20.Work();
            }                       // emp20.Dispose() will be called implicitly!
               
        }

        // PROBLEMS:
        // 1. Object may be disposed multiple times.
        //    - SOLVED (flag in the class "isDisposing")
        // 2. Object may not invoke a call to the Dispose() method
        //    - SOLVED (call the Dispose() method implicitly in the DESTRUCTOR)
        // 3. Method may be invoked for an object which is already Disposed
        //    - SOLVED: Check if the object is already disposed, before executing the logic of the method
        //      FOR ALL METHODS!!!!!
        // 4. If the class has DataFields, the datafields are accessible even after disposing the object
        //    - SOLVED: Convert all datafields into Property Signatures, 
        //              and in the SET & GET accessors, check if object is in Disposal State
        private static void Demo01()
        {
            Employee emp1 = new Employee(1, "First Employee");
            Employee emp2 = new Employee(2, "Second Employee");

            emp1.Salary = 5000;
            emp2.Salary = 10000;
            Console.WriteLine("Salary of emp1 : {0}", emp1.Salary);
            Console.WriteLine("Salary of emp2 : {0}", emp2.Salary);
            Console.WriteLine();

            emp1.Work();
            emp2.Work();

            emp2.Dispose();

            // application will crash - object is already disposed!
            // emp2.Salary = 50000;                                                             // SET
            // Console.WriteLine("Salary of the Disposed emp2 object is : {0}", emp2.Salary);   // GET

            // emp2.Work();                       // application will crash - object is already disposed!

            // emp2.Dispose();                 // application will crash - object is already disposed!

            // emp1.Dispose();  is not being called. Dispose() is called implicitly from the DESTRUCTOR
        }
    }
}
