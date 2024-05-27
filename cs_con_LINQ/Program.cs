using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using System.Linq;                              // HAS TO BE ADDED MANUALLY FOR LINQ TO WORK

namespace cs_con_LINQ
{
    // LINQ: Language Integrated Query

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            
            employees.Add(new Employee() { Id = 4, Name = "Fourth Employee", Age = 18 });
            employees.Add(new Employee() { Id = 2, Name = "Second Employee", Age = 35 });
            employees.Add(new Employee() { Id = 5, Name = "Fifth Employee", Age = 29 });
            employees.Add(new Employee() { Id = 3, Name = "Third Employee", Age = 42 });
            employees.Add(new Employee() { Id = 1, Name = "First Employee", Age = 27 });

            Console.WriteLine("List of the employees in the collection");
            foreach(Employee e in employees)
            {
                Console.WriteLine("{0} {1,-20} {2}", e.Id, e.Name, e.Age);
            }
            Console.WriteLine();


            Employee[] employeesCopy = new Employee[employees.Count];
            employees.CopyTo(employeesCopy);
            Array.Sort(employeesCopy);
            Console.WriteLine("List of the employees in the collection - After Sorting (IComparable)");
            foreach (Employee e in employeesCopy)
            {
                Console.WriteLine("{0} {1,-20} {2}", e.Id, e.Name, e.Age);
            }
            Console.WriteLine();



            Console.WriteLine("in Descending Order of ID");
            for (int i = employeesCopy.Length - 1; i > -1; i--)
            {
                Console.WriteLine("{0} {1,-20} {2}",
                    employeesCopy[i].Id, employeesCopy[i].Name, employeesCopy[i].Age);
            }
            Console.WriteLine();

            Console.WriteLine("List of the employees in the collection (ORIGINAL DATA)");
            foreach (Employee e in employees)
            {
                Console.WriteLine("{0} {1,-20} {2}", e.Id, e.Name, e.Age);
            }
            Console.WriteLine();

            Console.Write("Press any key to continue....");
            Console.ReadKey();
            Console.Clear();


            // LINQ (Language Integrated Query)
            var query = from e in employees
                        orderby e.Name
                        select e;
            Console.WriteLine("List of the employees in the collection - After Sorting using LINQ");
            foreach (Employee e in query)
            {
                Console.WriteLine("{0} {1,-20} {2}", e.Id, e.Name, e.Age);
            }
            Console.WriteLine();

            Console.WriteLine("List of the employees in the collection (ORIGINAL DATA)");
            foreach (Employee e in employees)
            {
                Console.WriteLine("{0} {1,-20} {2}", e.Id, e.Name, e.Age);
            }
            Console.WriteLine();



            Console.WriteLine("List of the employees in the collection and filtering it (ORIGINAL DATA)");
            foreach (Employee e in employees)
            {
                if (e.Age < 30)
                {
                    Console.WriteLine("{0} {1,-20} {2}", e.Id, e.Name, e.Age);
                }
            }
            Console.WriteLine();

            var query2 = from e in employees
                         where e.Age < 30
                         orderby e.Age descending
                         select e;
            Console.WriteLine("List of the employees in the collection - After Filtering and Sorting using LINQ");
            foreach (Employee e in query2)              // query2.GetEmumerator() is called here!
            {
                Console.WriteLine("{0} {1,-20} {2}", e.Id, e.Name, e.Age);
            }
            Console.WriteLine();




            // LINQ with Projection
            var query3 = from e in employees
                         select new                     // Anonymous Object
                         {
                             ObjectId = e.Id,
                             e.Name,
                             e.Age,
                             Address = $"Address #{e.Id} in Some City"
                         };
            Console.WriteLine("List of objects using LINQ after Projection");
            foreach (var e in query3)
            {
                Console.WriteLine("{0} {1,-20} {2} {3}", e.ObjectId, e.Name, e.Age, e.Address);
            }
            Console.WriteLine();


            // ------ Examples of LINQ and its LAMBDA alternatives.


            var q1a = from e in employees
                      select e;
            var q1b = employees.Select(e => e);


            var q2a = from e in employees
                      where e.Age < 30
                      select e;
            var q2b = employees.Where(e => e.Age < 30);


            var q3a = from e in employees
                      orderby e.Name descending
                      where e.Age < 30
                      select e;
            var q3b = employees.Where(e => e.Age < 30)
                               .OrderByDescending(e => e.Name);


            var q4 = from e in q2a
                      orderby e.Name descending
                      select e;
            foreach (var e in q4)           // LINQ Query will execute here!
            {
            }

            Employee thirdEmployee = (from e in employees
                                      where e.Id == 3
                                      select e).SingleOrDefault();
            if(thirdEmployee != null)
            {
            }

            bool doesSharmaExist = employees.Any(e => e.Name == "Sharma");


            var paginatedEmployees1 = (from e in employees
                                       select e).Skip(2).Take(3);       // fluent API Coding
            var paginatedEmployees2 = employees.Skip(2).Take(3);         // [2], [3], [4]


            var q5a = from e in employees
                      select new                     // Anonymous Object
                      {
                        ObjectId = e.Id,
                        e.Name,
                        e.Age,
                        Address = $"Address #{e.Id} in Some City"
                      };
            foreach(var item in q5a)            // executes the LINQ query
            {

            }
            var q5b = employees
                        .Select(e => new {
                            ObjectId = e.Id,
                            e.Name,
                            e.Age,
                            Address = $"Address #{e.Id} in Some City"
                        })
                        .Where(e => e.ObjectId > 2)
                        .OrderBy(e => e.Name);   
            foreach(var item in q5b)            // executes the query (implicitly calling GetEnumerator() method )
            {
            }
            
            var q5c = q5b.ToList();             // executes the Query AGAIN!!!! (calling ToList() method )
            foreach(var item in q5c)
            {
            }
        }
    }
}
