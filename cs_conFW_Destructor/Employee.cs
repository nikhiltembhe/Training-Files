using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_conFW_Destructor
{
    internal class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }

        // Type Constructor
        static Employee()
        {
            Console.WriteLine("Type Constructor of Employeee executed");
        }

        // Instance Constructor
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
            Console.WriteLine($"Employee Object with ID {this.Id} is instantiated");
        }

        // Instance Destructor/Finalizer
        ~Employee()
        {
            Console.WriteLine($"Employee Object with ID {this.Id} is destroyed");
        }
    }
}
