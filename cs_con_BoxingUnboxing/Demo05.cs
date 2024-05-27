using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_BoxingUnboxing
{
    internal class Demo05
    {
        // AS OPERATOR works only with Reference Types
        public static void RunThis()
        {
            A objA = new A();
            objA.ID = 10;

            B objB = new B();
            objB.Name = "hello world";

            object o = objA;            // Boxing

            // B objB2 = (B)o;             // Unboxing of the wrong type

            B objB3 = o as B;              // Unboxing using the AS operator (safe type-casting operator)
            if(objB3 == null)
            {
                Console.WriteLine("o is not a proper B type variable");
            }
            else
            {
                Console.WriteLine(objB3.Name);
            }
        }
    }

    class A
    {
        public int ID;
    }

    class B
    {
        public string Name;
    }
}
