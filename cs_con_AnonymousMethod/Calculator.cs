using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_AnonymousMethod
{
    delegate int ComputeHandler(int a, int b);

    internal class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Compute(ComputeHandler objD, int a, int b)
        {
            int result = default;   // "default" default value of the datatype (int)

            if (objD != null)       // check if the delegate is subscribed
            {
                result = objD(a, b);        // invoke the call to the delegate
            }

            return result;         
        }
    }
}
