namespace cs_con_MethodParameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;

            Console.WriteLine("DEMO: Pass by Value");
            i = 10;
            Console.WriteLine($"Before calling: i = {i}");
            PassByValue(i);
            Console.WriteLine($"After calling: i = {i}");
            Console.WriteLine();

            Console.WriteLine("DEMO: Pass by Reference");
            i = 10;                         // reset the variable
            Console.WriteLine($"Before calling: i = {i}");
            PassByReference(ref i);
            Console.WriteLine($"After calling: i = {i}");
            Console.WriteLine();

            Console.WriteLine("DEMO: Pass by Out");
            i = 10;                         // reset the variable
            Console.WriteLine($"Before calling: i = {i}");
            PassByOut(out i);
            Console.WriteLine($"After calling: i = {i}");
            Console.WriteLine();

            // Demo of OUTPUT Parameter example.
            Demo.RunThis();
            Console.WriteLine();

            Console.WriteLine("DEMO: Variable number of Parameters");
            VariableNumberOfParameters(10, 20);
            VariableNumberOfParameters(100, 200, 300, 400);
            VariableNumberOfParameters(9);
            VariableNumberOfParameters();
            VariableNumberOfParameters(null);
        }

        static void PassByValue(int x)
        {
            Console.WriteLine($"--- received x = {x}");
            x = 50;
            Console.WriteLine($"--- after changing, x = {x}");
        }

        // RULES for REF parameters
        // 1. All REF parameters need to be Initialized 
        //    before entering the method.
        static void PassByReference(ref int x)
        {
            Console.WriteLine($"--- received x = {x}");
            x = 50;
            Console.WriteLine($"--- after changing, x = {x}");
        }

        // RULES for OUT parameters
        // 1. All Out Parameters need to be Initialized
        //    inside the method, before exiting the method
        // 2. Out Parameter cannot be accessed until it has been initialized
        static void PassByOut(out int x)
        {
            // Console.WriteLine($"--- received x = {x}"); // Compiler Error (Rule #2)

            x = 50;             // to address Rule #1
            Console.WriteLine($"--- after initializing, x = {x}");
        }


        static void VariableNumberOfParameters(params int[]? arr)
        {
            if (arr != null)
            {
                Console.WriteLine("Number of parameters received: {0}", arr.Length);

                foreach (int i in arr)
                {
                    Console.Write("{0} ", i);
                }

                if(arr.Length == 0)
                    Console.WriteLine("Did not receive any parameter at all!");
            }
            else
            {
                Console.WriteLine("Received NULL");
            }

            Console.WriteLine();
        }

    }
}