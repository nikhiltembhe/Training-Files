using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("THREAD example");
            Demo01.Run();
            Console.WriteLine();

            Console.WriteLine("TASK FACTORY example");
            Demo02.Run();
            Console.WriteLine();

            Console.WriteLine("Another TASK FACTORY example");
            Demo03.Run();
            Console.WriteLine();
        }
    }
}
