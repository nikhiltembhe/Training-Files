using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("---- Demo of Typecasting");
            // Demo01.RunThis();
            // Console.WriteLine();

            Console.WriteLine("---- Demo of Polymorphism - OVERLOAD");
            Demo02.RunThis();
            Console.WriteLine();

            Console.WriteLine("---- Demo of Polymorphism - BOXING");
            Demo03.RunThis();
            Console.WriteLine();

            Console.WriteLine("Demo of Polymorphism and Boxing & Unboxing");
            Demo04.RunThis();

            // Demo05.RunThis();
        }
    }
}
