using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Constructors_Inheritance
{
    internal class Demo01
    {
        class A
        {
            public A()
            {
                Console.WriteLine("constructor of base class (A) invoked");
            }
        }

        class B : A
        {
            public B()
            {
                Console.WriteLine("constructor of derived class (B) invoked");
            }
        }


        public static void RunThis()
        {
            Console.WriteLine("A objA = new A()");
            A objA = new A();           // A()
            Console.WriteLine();

            Console.WriteLine("B objB = new B()");
            B objB = new B();           // A(), B()
        }


    }


}
