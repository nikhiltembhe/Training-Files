using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Constructors
{
    internal class Demo01
    {

        static public void RunThis()
        {
            Employee e;                             // Declaration
            e = new Employee("second employee");    // Instantiation (when Constructor is called)

            Employee emp = new Employee("First Employee");
            Console.WriteLine("{0}", emp.Name);
        }

        class Employee
        {
            // backing field
            private string _name;

            // Readonly Property (only get is there)
            public string Name
            {
                get
                {
                    return _name;
                }
            }

            // Construtor
            // Initalize all internal instance members
            public Employee(string name)
            {
                _name = name;
            }
        }
    }
}
