using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Delegate
{
    // STEP #1: Define the signature of the Method to be invoked.
    delegate int ComputeHandler(int x, int y);

    sealed class Calculator
    {
        public int Add(int a, int b)
        {
            Console.WriteLine("Encapsulation Steps: 1. 2. 3. 4. 5.");
            return a + b;
        }

        // STEP #2: Defines the method which will receive the pointer to the method to be invoked
        //          along with parameters
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">First Number</param>
        /// <param name="b">Second Number</param>
        /// <param name="objD">Method whose signature matches with what is specified by the DELEGATE</param>
        /// <returns></returns>
        public int Compute(int a, int b, ComputeHandler objD)
        {
            int result = -1;

            Console.WriteLine("Encapsulation Step: 1 Authentication");
            Console.WriteLine("Encapsulation Step: 2 Authorization");
            Console.WriteLine("Encapsulation Step: 3 Validation");

            // STEP #3: Check if the Delegate is "subscribed"
            if (objD != null)
            {
                Console.WriteLine("Encapsulation Step: 4 Acitivity/Process");

                // STEP #4: Invoke the Delegate (call the callback methods)
                result = objD(a, b);                        // SAME AS: result = objD.Invoke(a, b);
            }

            Console.WriteLine("Encapsulation Step: 5 Audit Logging");

            return result;
        }

    }

}
