using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_BoxingUnboxing
{
    internal class Demo03
    {
        public static void RunThis()
        {
            int i = 10;
            bool b = true;
            string s = "Hello world";

            m(i);       // implicit boxing

            object o = b;
            m(o);      // explicit boxing

            m(s);       // implicit boxing
        }

        static void m(object x)
        {
            Console.WriteLine("Received {0}, type: {1}", x, x.GetType());
        }

    }
}
