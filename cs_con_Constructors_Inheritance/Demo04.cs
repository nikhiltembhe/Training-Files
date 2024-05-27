using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Constructors_Inheritance
{
    internal class Demo04
    {
        class A
        {
            //public A()
            //{
            //    Console.WriteLine("instance constructor of (A) invoked");
            //}

            public A(int id)
            {
                Console.WriteLine("instance constructor of (A) with parameter invoked");
            }
        }

        class B : A
        {
            public B() : this(0)
            {
                Console.WriteLine("instance constructor of (B) invoked");
            }

            public B(int id) : base(id)
            {
                Console.WriteLine("instance constructor with parameter of (B) invoked");
            }
        }


        public static  void RunThis()
        {
            Console.WriteLine("B objB1 = new B();");
            B objB1 = new B();
            Console.WriteLine();

            Console.WriteLine("B objB2 = new B(10);");
            B objB2 = new B(20);
            Console.WriteLine();
        }
    }
}
