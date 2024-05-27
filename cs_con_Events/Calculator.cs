using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Events
{
    delegate int ComputeHandler(int a, int b);

    // STEP #1: Declare the Delegate for the Event
    delegate void ErrorHandler(string message);           

    class Calculator
    {
        // STEP #2: Declare the object variable for the Event
        //          The return type of the Event is the Delegate.
        //          The Event should be for the object
        public event ErrorHandler OnError;                // declared like a typical data-field.

        public int Compute(ComputeHandler objD, int a, int b)
        {
            int result = -1;
            if(objD != null)                    // check if delegate is subscribed
            {
                try
                {
                    result = objD(a, b);        // invoke the call to the delegated method!
                }
                catch
                {
                    // STEP #3: Check if the event is subscribed
                    if (this.OnError != null)    
                    {
                        // STEP #4: Raise the event
                        this.OnError("ERROR: something went wrong!");
                    }
                }
            }
            return result;
        }
    }
}
