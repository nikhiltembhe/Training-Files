using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyGenericType<int> myInt = new MyGenericType<int>();
            myInt.Value = 10;
            myInt.m();
            myInt.n();
            Console.WriteLine(myInt.Value);
            Console.WriteLine();

            MyGenericType<Employee> myEmp = new MyGenericType<Employee>();
            myEmp.Value = new Employee() { Id = 1, EmployeeName = "First Employee" };
            myEmp.m();
            myEmp.n();
            Console.WriteLine(myEmp.Value.EmployeeName);
            Console.WriteLine();

            MyCollection<int> myIntCollection = new MyCollection<int>();
            myIntCollection.Add(10);
            myIntCollection.Add(20);
            myIntCollection.Add(30);
            myIntCollection.Add(40);
            Console.WriteLine("Items in the Integer Collection:");
            foreach(int i in myIntCollection)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine("Second element in the Integer Collection: {0}", myIntCollection[1]);
            myIntCollection.RemoveAt(1);
            Console.WriteLine("Items in the Integer Collection after removing the second element:");
            foreach (int i in myIntCollection)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            Console.WriteLine();

            MyCollection<Employee> myEmpCollection = new MyCollection<Employee>();
            myEmpCollection.Add(new Employee { Id = 1, EmployeeName = "First Employee" });
            myEmpCollection.Add(new Employee { Id = 2, EmployeeName = "Second Employee" });
            myEmpCollection.Add(new Employee { Id = 3, EmployeeName = "Third Employee" });
            myEmpCollection.Add(new Employee { Id = 4, EmployeeName = "Fourth Employee" });
            myEmpCollection.Add(new Employee { Id = 5, EmployeeName = "Fifth Employee" });
            Console.WriteLine("Employees in the Employees Collection");
            foreach(Employee emp in myEmpCollection)
            {
                Console.WriteLine(emp);
            }

            // built in collections
            System.Collections.Generic.List<int> intList = new List<int>()
            {
                1, 2, 3, 4, 5
            };
            intList.Add(50);

            Console.WriteLine();

            List<Employee> empList = new List<Employee>()
            {
                new Employee { Id = 4, EmployeeName = "Fourth Employee" },
                new Employee { Id = 3, EmployeeName = "Third Employee" },
                new Employee { Id = 5, EmployeeName = "Fifth Employee" },
                new Employee { Id = 1, EmployeeName = "First Employee" },
                new Employee { Id = 2, EmployeeName = "Second Employee" },
            };
            Console.WriteLine("---- unsorted employee list");
            foreach(Employee emp in empList)
            {
                Console.WriteLine($"{emp.Id} {emp.EmployeeName}");
            }

            empList.Sort(
                (lhs, rhs) =>
                {
                    return lhs.EmployeeName.CompareTo(rhs.EmployeeName);
                });

            Console.WriteLine("---- sorted employee list");
            empList.ForEach(emp =>
            {
                Console.WriteLine($"{emp.Id} {emp.EmployeeName}");
            });

        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }

        public override string ToString()
        {
            return $"ID: {this.Id}, Name: {this.EmployeeName}";
        }
    }
}
