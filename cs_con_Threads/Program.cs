using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace cs_con_Threads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========== Methods are called Synchronously");
            Demo01();
            Console.WriteLine();

            Console.WriteLine("=========== Methods are called Aynchronously");
            Demo02();
            Console.WriteLine();

            Console.WriteLine("------ exiting MAIN()");
        }

        private static void Demo02()
        {
            Console.WriteLine("--- Demo02() called on Thread: {0}", Thread.CurrentThread.ManagedThreadId);

            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            // ThreadStart = void ()
            // ParameterizedThreadStart = void (object)

            Console.WriteLine("calling m() from Thread: {0} Asynchronously", Thread.CurrentThread.ManagedThreadId);
            Thread t1 = new Thread(new ThreadStart(Program.m));
            t1.Start();

            Console.WriteLine("calling n() from Thread: {0} Asynchronously", Thread.CurrentThread.ManagedThreadId);
            Thread t2 = new Thread(new ParameterizedThreadStart(Program.n));
            t2.Start(50);           // Program.n(50);


            // NOTE: Wait for each of the threads to complete their tasks and join back to Parent Thread
            t1.Join();
            t2.Join();

            stopwatch.Stop();
            Console.WriteLine("Total Time taken: {0} milliseconds", stopwatch.ElapsedMilliseconds);
        }

        private static void Demo01()
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            Console.WriteLine("calling m() from Thread: {0}", Thread.CurrentThread.ManagedThreadId);
            Program.m();

            Console.WriteLine("calling n() from Thread: {0}", Thread.CurrentThread.ManagedThreadId);
            Program.n(10);

            stopwatch.Stop();
            Console.WriteLine("Total Time taken: {0} milliseconds", stopwatch.ElapsedMilliseconds);
        }

        static void m()
        {
            Console.WriteLine("--- m() called on Thread: {0}", Thread.CurrentThread.ManagedThreadId);
            System.Threading.Thread.Sleep(3000);        // sleep for 3 seconds
        }

        static void n(object obj)
        {
            Console.WriteLine("--- n() called on Thread: {0} with the parameter: {1}", 
                Thread.CurrentThread.ManagedThreadId, obj);
            System.Threading.Thread.Sleep(5000);        // sleep for 5 seconds
        }
    }
}
