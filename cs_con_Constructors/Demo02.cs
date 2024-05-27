using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Constructors
{
    internal class Demo02
    {

        // C# Language Compiler will ADD the default Constructor,
        //  ONLY if developer HAS NOT defined any constructor
        class ClassA
        {

        }


        // Developer has added the constructor.  So, C# Language compiler WILL NOT add the default constructor.
        class ClassB
        {
            public ClassB()
            {

            }
        }

        class ClassC
        {
            // Paramterized Constructor 
            public ClassC(int id)
            {

            }
        }

        class ClassD
        {
            // Default Constructor / Parameterless Constructor
            public ClassD()
            {

            }

            // Parameterized constructor 
            public ClassD(int id)
            {

            }

        }

    }
}
