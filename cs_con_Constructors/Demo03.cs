using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Constructors
{
    internal class Demo03
    {
        public static void RunThis()
        {
            MyDerivedClass obj1 = new MyDerivedClass(10);
            Console.WriteLine();
        }


        class MyBaseClass
        {
            //public MyBaseClass()
            //{
            //    Console.WriteLine("Base class default constructor called!");
            //}

            public MyBaseClass(int x)
            {
                Console.WriteLine("Base class Parameterized constructor called");
            }
        }

        class MyDerivedClass : MyBaseClass
        {
            public MyDerivedClass() : base(0)
            {
                Console.WriteLine("Default constructor of the Derived class is called");
            }

            public MyDerivedClass(int id) : base(id)
            {
                Console.WriteLine("Parameterized constructor of the derived class called");
            }
        }

    }
}
