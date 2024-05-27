using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_AnonymousTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //  DemoOfTypeInference();

            DemoOfAnonymousType();
        }

        static void DemoOfTypeInference()
        {
            int i = 10;
            Console.WriteLine("Value of i = {0}", i);                       // 10
            Console.WriteLine("DataType of i = {0}", i.GetType());          // System.Int32
            i++;
            Console.WriteLine();

            // Boxing
            object o = i;           // boxing
            Console.WriteLine("Value of o = {0}", o);                       // 10
            Console.WriteLine("DataType of o = {0}", o.GetType());          // System.Int32
            // o++;
            o = (int)o + 1;         // unboxing
            Console.WriteLine();

            // Type Inference (infer the datatype on Assignment)
            var j = 10;
            // var k;
            Console.WriteLine("Value of j = {0}", j);
            Console.WriteLine("DataType of j = {0}", j.GetType());
            j++;
            Console.WriteLine();

            System.Collections.ArrayList list1 = new System.Collections.ArrayList();
            var list2 = new System.Collections.ArrayList();
        }

        static void DemoOfAnonymousType()
        {
            // Declaration is by the Type
            Employee emp1 = new Employee() { Id = 10, Name = "First Employee" };
            Console.WriteLine("ID: {0}, Name = {1}, Type: {2}", emp1.Id, emp1.Name, emp1.GetType());
            emp1.Id = 50;
            emp1.Work();
            Console.WriteLine();


            // Type is inferred
            var emp2 = new Employee() { Id = 20, Name = "Inferred Employee " };
            Console.WriteLine("ID: {0}, Name = {1}, Type: {2}", emp2.Id, emp2.Name, emp2.GetType());
            emp2.Id = 50;
            emp2.Work();
            Console.WriteLine();

            // Anonymous Type (light-weight, readonly object)
            // 1. The Type is dynamically generated during Compile Time
            // 2. All Properties are READONLY
            // 3. Cannot have methods
            // 4. Cannot be inherited
            // 5. Cannot be abstract class
            var emp3 = new { Id = 30, Name = "Anonymous Employee" };
            Console.WriteLine("ID: {0}, Name = {1}, Type: {2}", emp3.Id, emp3.Name, emp3.GetType());
            // emp3.Id = 50;                   // readonly properties ONLY!
            Console.WriteLine();

            Console.WriteLine("-----------------------------");

            Employee emp1b = new Employee() { Name = "Second Employee", Id = 11 };
            Console.WriteLine("ID: {0}, Name = {1}, Type: {2}", emp1b.Id, emp1b.Name, emp1b.GetType());
            Console.WriteLine();

            // A new Anonymous Type is created if property signatures change.
            var emp3b = new { Name = "Anonymous Employee - 2", Id = 31 };
            Console.WriteLine("ID: {0}, Name = {1}, Type: {2}", emp3b.Id, emp3b.Name, emp3b.GetType());
            Console.WriteLine();

            // A new Anonymous Type is NOT created because properties match
            var emp3c = new { Id = 32, Name = "Anonymous Employee - 3" };
            Console.WriteLine("ID: {0}, Name = {1}, Type: {2}", emp3c.Id, emp3c.Name, emp3c.GetType());
            Console.WriteLine();

            // A new Anonymous Type is created if PROPERTY SIGNATURES change (name and data-type of property)
            var emp3d = new { Number = 33, Name = "Anonymous Employee - 4" };
            Console.WriteLine("Number: {0}, Name = {1}, Type: {2}", emp3d.Number, emp3d.Name, emp3d.GetType());
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("Anonymous Type -  GetType() of Id: {0}", emp1.Id.GetType());
            Console.WriteLine("Employee Type -   GetType() of Id: {0}", emp3.Id.GetType());

            Console.WriteLine();
            Console.WriteLine("Anonymous Type -  GetType() of Name : {0}", emp1.Name.GetType());
            Console.WriteLine("Employee Type -   GetType() of Name : {0}", emp3.Name.GetType());

        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Work()
        {

        }
    }
}
