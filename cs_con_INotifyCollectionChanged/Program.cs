using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_INotifyCollectionChanged
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // example of Collection Initializer
            //  implicitly calls the Add() method of the Company Class
            Company objCompany = new Company("Microsoft")
            {
                new Employee { Id = 1, Name = "First Employee", Designation = "Developer", Salary = 20000 },
                new Employee { Id = 2, Name = "Second Employee", Designation = "Clerk", Salary = 2100 },
                new Employee { Id = 3, Name = "Third Employee", Designation = "Manager", Salary = 220 },
                new Employee { Id = 4, Name = "Fourth Employee", Designation = "Developer", Salary = 25000 },
                new Employee { Id = 5, Name = "Fifth Employee", Designation = "Accountant", Salary = 50000 }
            };

            foreach(Employee emp in objCompany)         // invokes objCompany.GetEnumerator()
            {
                Console.WriteLine($"{emp.Id,2} {emp.Name, -20} {emp.Designation, -15} {emp.Salary,20:C}");
            }
            Console.WriteLine();

            // Subscribe to the INotifyCollectionChanged event
            objCompany.CollectionChanged += ObjCompany_CollectionChanged;

            // example of Object/Property Initializer being called while instantiating an object
            Console.WriteLine("ADDING A NEW EMPLOYEE NOW");
            objCompany.Add(
                new Employee()
                {
                    Id = 10,
                    Name = "Employee #10",
                    Designation = "CEO",
                    Salary = 500000
                });

            Employee empFind = objCompany["Third Employee"];
            if (empFind != null)
            {
                Console.WriteLine("REMOVING AN EXISTING EMPLOYEE NOW");
                objCompany.Remove(empFind);
            }

            Console.WriteLine("FINALLY, aftter Adding an Employee, and Removing existing Employee");
            foreach (Employee emp in objCompany)
            {
                Console.WriteLine($"{emp.Id,2} {emp.Name,-20} {emp.Designation,-15} {emp.Salary,20:C}");
            }
            Console.WriteLine();

        }


        private static void ObjCompany_CollectionChanged(
            object sender, 
            System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    Console.WriteLine("The following employee(s) were ADDED!");
                    foreach(Employee emp in e.NewItems)
                    {
                        Console.WriteLine($"\t{emp.Id} {emp.Name}");
                    }
                    Console.WriteLine();
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("The following employee(s) were removed!");
                    foreach (Employee emp in e.OldItems)
                    {
                        Console.WriteLine($"\t{emp.Id} {emp.Name}");
                    }
                    Console.WriteLine();
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
                case System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
                    break;
                default:
                    break;
            }
        }
    }
}
