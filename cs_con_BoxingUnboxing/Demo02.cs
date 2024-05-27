using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_BoxingUnboxing
{
    // Overloaded Versions of the method 
    internal class Demo02
    {
        public static void RunThis()
        {
            int i = 10;
            bool b = true;
            string s = "Hello world";

            m(i);
            m(b);
            m(s);
        }

        static void m(int x)
        {
            Console.WriteLine("Received {0}, type: {1}", x, x.GetType());
        }

        static void m(bool x)
        {
            Console.WriteLine("Received {0}, type: {1}", x, x.GetType());
        }

        static void m(string x)
        {
            Console.WriteLine("Received {0}, type: {1}", x, x.GetType());
        }
    }
}
