using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator objCalc = new Calculator();

            int a = 10;
            int b = 40;
            int result = objCalc.Add(a, b);
            Console.WriteLine($"Sum of {a} and {b} is {result}");
            Console.WriteLine();

            Console.WriteLine("---- Calling the method directly");
            result = Program.Subtract(a, b);
            Console.WriteLine($"Subtracting {a} from {b}, result = {result}");
            Console.WriteLine();


            Console.WriteLine("---- Calling the method indirectly using the DELEGATE");
            result = objCalc.Compute(a, b, Program.Subtract);           // delegate variable is created implicitly by boxing.
            Console.WriteLine($"Subtracting {a} from {b}, result = {result}");
            Console.WriteLine();

            // Same as above
            ComputeHandler objD = new ComputeHandler(Program.Subtract); // delegate variable is created Explicitly.
            result = objCalc.Compute(a, b, objD);
            Console.WriteLine($"Subtracting {a} from {b}, result = {result}");
            Console.WriteLine();

            // Program p = new Program();
            // result = objCalc.Compute(a, b, p.Multiply);

            result = objCalc.Compute(a, b, (new Program()).Multiply);
            Console.WriteLine($"{a} multiplied by {b}, result = {result}");
            Console.WriteLine();
        }

        // called back methods
        private static int Subtract(int a, int b)
        {
            Console.WriteLine("----- Subtract() from Program class called!");
            return b - a;
        }

        private int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
