using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Constructors
{
    internal class Demo04
    {
        public static void RunThis()
        {
            Demo04.Person p1 = new Demo04.Person("First person");
            Demo04.Person p2 = new Demo04.Person("Second person");

            Console.WriteLine("{0} {1}", p1.ID, p1.Name);
            Console.WriteLine("{0} {1}", p2.ID, p2.Name);
            Console.WriteLine();
        }

        class Person
        {
            // Instance member (belongs to the object)
            public readonly int ID;
            public readonly string Name;

            // Type member (shared amongst all objects of the class)
            static private int counter;

            // Type Constructor
            // used to initialize type member
            static Person()
            {
                Person.counter = 0;
            }

            // Instance Constructor
            // used to initialize instance members
            public Person(string name)
            {
                this.ID = ++Person.counter;
                this.Name = name;
            }
        }

    }
}
