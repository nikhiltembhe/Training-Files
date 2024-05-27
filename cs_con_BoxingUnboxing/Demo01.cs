using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_BoxingUnboxing
{
    internal class Demo01
    {
        public static void RunThis()
        {
            // implicitly type-cast/convert
            int i = 10;         // System.Int32
            long l = i;         // System.Int64
            Console.WriteLine("i = {0} Type: {1}", i, i.GetType());
            Console.WriteLine("l = {0} Type: {1}", l, l.GetType());
            Console.WriteLine();

            // explicitly type-cast/convert
            long x = 10;        // System.Int64
            int y = (int)x;     // System.Int32
            Console.WriteLine("x = {0} Type: {1}", x, x.GetType());
            Console.WriteLine("y = {0} Type: {1}", y, y.GetType());
            Console.WriteLine();


            // BOXING
            int m = 500;
            m++;

            string s = "hello world";
            s = s.ToUpper();


            object o = new object();
            Console.WriteLine("o is currently containing a value of the type: {0}", o.GetType());
            Console.WriteLine();

            o = m;           // Boxing of an Int32
            Console.WriteLine("o is currently containing a value of the type: {0}", o.GetType());
            Console.WriteLine();

            // o++;
            o = (int)o + 1;  // Unboxing

            o = s;                          // Boxing of a String
            Console.WriteLine("o is currently containing a value of the type: {0}", o.GetType());
            Console.WriteLine();

            // o = o.ToUpper();
            o = ((string)o).ToUpper();      // Unboxing


            Demo obj = new Demo();
            o = obj;                        // Boxing of a Refrence Object
            Console.WriteLine("o is currently containing a value of the type: {0}", o.GetType());
            Console.WriteLine();

            Demo obj2 = (Demo)o;            // Unboxing
        }
    }

    class Demo
    {

    }
}
