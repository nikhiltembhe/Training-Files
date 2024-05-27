using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Constructors_Inheritance
{
    internal class Demo02
    {
        class A
        {
            // Class Loader executes the static/type constructor
            static A()
            {
                Console.WriteLine("type constructor of base class (A) invoked");
            }

            // Code Manager executes the instance constructor
            public A()
            {
                Console.WriteLine("instance constructor of base class (A) invoked");
            }
        }

        class B : A
        {
            static B()
            {
                Console.WriteLine("type constructor of derived class (B) invoked");
            }

            public B()
            {
                Console.WriteLine("instance constructor of derived class (B) invoked");
            }
        }


        public static void RunThis()
        {
            //RunThisA();
            //Console.WriteLine();
            
            RunThisB();
            //Console.WriteLine();
            
            // RunThisC();
        }

        public static void RunThisA()
        {
            Console.WriteLine("A objA = new A()");
            A objA = new A();           // (s)A, (i)A
            Console.WriteLine();

            Console.WriteLine("A objA2 = new A()");
            A objA2 = new A();           // (i)A
            Console.WriteLine();
        }

        public static void RunThisB()
        {
            Console.WriteLine("B objB = new B()");
            B objB1 = new B();           // (s)B, (s)A, (i)A, (i)B
            Console.WriteLine();

            Console.WriteLine("B obB2 = new B()");
            B objB2 = new B();          // (i)A, (i)B
            Console.WriteLine();
        }

        public static void RunThisC()
        {
            // A objA = new B();        // Create an object of Parent with BEHAVIOURS as defined in the Child
            // B objB = new A();        // NOT POSSIBLE

            Console.WriteLine("A objA = new B()");
            A objA = new B();           // (s)B(), (s)A(), i(A), i(B)
            Console.WriteLine();
        }

    }
}
