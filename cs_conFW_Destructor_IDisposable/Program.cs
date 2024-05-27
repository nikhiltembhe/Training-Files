using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace cs_conFW_Destructor_IDisposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // m("First Employee");

            // m("Second Employee");

            // nonPerfect();       //  not calling dispose method
            // perfect();

            // benefit();

            Console.WriteLine();
            Console.WriteLine("===== exiting Main()");
            Console.WriteLine();
        }

        // Managing Resource Management Example
        static void benefit()
        {

            using (Employee emp = new Employee("BENEFIT employee"))
            {
                Console.WriteLine();
                emp.Work();

                Console.WriteLine();
                Console.WriteLine("Exiting the USING block");
            }                       // implicitly invokes a call to the Dispose() method on exiting the USING block

            Console.WriteLine();
            Console.WriteLine("Exiting the Resource Management example");
        }

        static void nonPerfect()
        {
            Employee emp = new Employee("NEW EMPLOYEE - NON PERFECT");

            Console.WriteLine();
            emp.Work();

            Console.WriteLine();
        }

        static void perfect()
        {
            Employee emp = new Employee("NEW EMPLOYEE - PERFECT");

            Console.WriteLine();
            emp.Work();

            Console.WriteLine();
            emp.Dispose();
        }

        static void m(string name)
        {
            Employee emp1 = new Employee(name);

            Console.WriteLine();
            emp1.Work();

            Console.WriteLine();
            Console.WriteLine("---- calling the Dispose() method now!");
            emp1.Dispose();


            try
            {
                Console.WriteLine();
                Console.WriteLine("----- ATTEMPT: calling Work() after the employee has been disposed!");
                emp1.Work();
            }
            catch(ObjectDisposedException exp)
            {
                Console.WriteLine("Something went wrong!");
                Console.WriteLine("Object Name : {0}", exp.ObjectName);
                Console.WriteLine("Message: {0}", exp.Message);
            }


            try
            {
                Console.WriteLine();
                Console.WriteLine("----- ATTEMPT: calling Dispose() the second time");
                emp1.Dispose();
            }
            catch (ObjectDisposedException exp)
            {
                Console.WriteLine("Something went wrong!");
                Console.WriteLine("Object Name : {0}", exp.ObjectName);
                Console.WriteLine("Message: {0}", exp.Message);
            }

            try
            {
                Console.WriteLine();
                Console.WriteLine("----- ATTEMPT: change the datafield/property of the object");
                emp1.Name = emp1.Name + " -- changed!";
            }
            catch (ObjectDisposedException exp)
            {
                Console.WriteLine("Something went wrong!");
                Console.WriteLine("Object Name : {0}", exp.ObjectName);
                Console.WriteLine("Message: {0}", exp.Message);
            }


        }

    }
}
