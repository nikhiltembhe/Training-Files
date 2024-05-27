using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator objCalc = new Calculator();

            int x = 5;
            int y = 20;
            int result = objCalc.Add(x, y);
            Console.WriteLine($"Sum of {x} and {y} = {result}");
            Console.WriteLine();

            // Calling the Static method directly.
            result = MyExtensions.Subtract(objCalc, x, y);
            Console.WriteLine("Result = {0}", result);
            Console.WriteLine();

            // Calling the Extension Method
            result = objCalc.Subtract(x, y);
            Console.WriteLine("Result = {0}", result);
            Console.WriteLine();

            int i = 10;
            i.Author();         // invoking extension method

            objCalc.Author();   // invoking the explicitly implemented method of the Calculator Class!


        }
    }
}
