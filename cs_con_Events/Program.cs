using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Events
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator objCalc = new Calculator();
            int result;
            int a, b;

            a = 5;
            b = 20;

            ComputeHandler objD = new ComputeHandler(Program.Add);
            result = objCalc.Compute(objD, a, b);
            Console.WriteLine($"Sum of {a} and {b} = {result}");

            result = objCalc.Compute(Program.Add, a, b);

            result = objCalc.Compute(
                delegate (int x, int y)
                {
                    return x + y;
                }, a, b);

            result = objCalc.Compute(
                (int x, int y) =>
                {
                    return x + y;
                }, a, b);

            result = objCalc.Compute(
                (x, y) =>
                {
                    return x + y;
                }, a, b);

            result = objCalc.Compute( 
                (x, y) => x + y, 
                a, b);

            result = objCalc.Compute((x, y) => x + y, a, b);
            Console.WriteLine($"Sum of {a} and {b} = {result}");

            Console.WriteLine();

            result = objCalc.Compute((x, y) => y - x, a, b);
            Console.WriteLine($"Subtracting {a} from {b} = {result}");

            Console.WriteLine();

            //---- Subscribe to the Event
            // objCalc.OnError += new ErrorHandler(Program.OnCalculatorError);
            objCalc.OnError += (message) =>
            {
                Console.WriteLine("Something went wrong: MESSAGE: {0}", message);
            };

            a = 10;
            b = 0;
            result = objCalc.Compute((x, y) => x / y, a, b);
            Console.WriteLine($"Dividing {a} by {b} = {result}");
        }

        private static int Add(int x, int y)
        {
            return x + y;
        }

        private static void OnCalculatorError(string message)
        {
            Console.WriteLine("Something went wrong: MESSAGE: {0}", message);
        }
    }
}
