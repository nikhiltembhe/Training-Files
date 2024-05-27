using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_ReferenceTypes
{
    // Derived Type
    internal class DeveloperEmployee : Employee
    {
        // Attribute of the Derived Type
        public string LaptopSerialNumber;

        // Constructor
        public DeveloperEmployee()
        {
            base.Designation = Designations.Developer;
        }

        override public void Work()
        {
            Console.WriteLine("Developer is programming something!");
            base.Work();
        }

        override public string ToString()
        {
            string output = base.ToString();
            output += $"\n  Laptop Serial #: {this.LaptopSerialNumber}";
            return output;
        }
    }
}
