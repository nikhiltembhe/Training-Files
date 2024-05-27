using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_AnonymousMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator objCalc = new Calculator();

            int x = 10;
            int y = 5;
            int result;

            result = objCalc.Add(x, y);
            Console.WriteLine($"Sum of {x} and {y} = {result}");

            // implicitly boxed as a Delegate Object
            result = objCalc.Compute(Program.Subtract, x, y);
            Console.WriteLine($"Difference between {x} and {y} = {result}");

            // explicitly done.
            ComputeHandler objD = new ComputeHandler(Program.Subtract);     // single-cast delegate
            result = objCalc.Compute(objD, x, y);
            Console.WriteLine($"1. Difference between {x} and {y} = {result}");


            // Anonymous Delegated method
            ComputeHandler objDb 
                = delegate (int a, int b)
                {
                    return b - a;
                };
            result = objCalc.Compute(objDb, x, y);
            Console.WriteLine($"2. Difference between {x} and {y} = {result}");
            Console.WriteLine();


            int m = 5;          // hook variable
            Console.WriteLine("m is = {0}", m);

            // Anonymously delegated method
            ComputeHandler objD2 
                = delegate (int a, int b)
                {
                    m++;
                    return a * b + m;
                };
            result = objCalc.Compute(objD2, x, y);
            Console.WriteLine($"Result = {result}");
            Console.WriteLine("m now is = {0}", m);
            Console.WriteLine();

            // LAMBDA EXPRESSION to define the anonymous method
            ComputeHandler objD3
                = (a, b) =>             // "=>" GOES TO operator
                {
                    return a * b;
                };
            result = objCalc.Compute(objD3, x, y);
            Console.WriteLine($"Result = {result}");

            ComputeHandler objD4 
                = (a, b) => a * b;
            result = objCalc.Compute(objD4, x, y);
            Console.WriteLine($"Result = {result}");

            Console.WriteLine($"Result = {objCalc.Compute( (a,b) => a * b, 100, 200)}");
       }

        private static int Subtract(int a, int b)
        {
            return b - a;
        }
    }
}
