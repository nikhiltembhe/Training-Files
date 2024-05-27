using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_ExtensionMethods
{
    // Design Pattern: Singleton pattern
    static class MyExtensions
    {
        // 1. The class is a Singleton Class (declared as "static" class)
        // 2. The method is a "public" so it can be accessed by outside code.
        // 3. The FIRST PARAMETER is an object of the class (to inject the method to the object).
        // 4. Decorate the first parameter with the "this" keyword
        // 5. Will be called ONLY IF no explicit implementation exists on the extended object.
        static public int Subtract(this Calculator objCalc, int a, int b)
        {
            return b - a;
        }


        static public void Author(this object o)
        {
            Console.WriteLine("Some developer is the Author of {0}", o.GetType());
        }
    }
}
