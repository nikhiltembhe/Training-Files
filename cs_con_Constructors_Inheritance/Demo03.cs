using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Constructors_Inheritance
{
    internal class Demo03
    {
        class A
        {
            // Class Loader of the CLR executes the static/type constructor
            static A()
            {
                Console.WriteLine("type constructor of (A) invoked");
            }

            // Code Manager of the CLR executes the instance constructor
            public A()
            {
                Console.WriteLine("instance constructor of (A) invoked");
            }
        }

        class B : A
        {
            // Class Loader executes the static/type constructor
            static B()
            {
                Console.WriteLine("type constructor of (B) invoked");
            }

            // Code Manager executes the instance constructor
            public B()
            {
                Console.WriteLine("instance constructor of (B) invoked");
            }
        }

        class C : B
        {
            // Class Loader executes the static/type constructor
            static C()
            {
                Console.WriteLine("type constructor of (C) invoked");
            }

            // Code Manager executes the instance constructor
            public C()
            {
                Console.WriteLine("instance constructor of (C) invoked");
            }
        }

        class D : C
        {
            // Class Loader executes the static/type constructor
            static D()
            {
                Console.WriteLine("type constructor of (D) invoked");
            }

            // Code Manager executes the instance constructor
            public D()
            {
                Console.WriteLine("instance constructor of (D) invoked");
            }
        }


        public static void RunThis()
        {
            Console.WriteLine("B objB = new D()");
            B objB = new D();           // sD, sC, sB, sA, iA, iB, iC, iD
            Console.WriteLine();
        }
    }
}
