using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;
using System.Threading.Tasks;

namespace cs_con_Tasks_AsyncAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result;
            //Console.WriteLine("--- Starting MAIN on Thread: {0}", Thread.CurrentThread.ManagedThreadId);
            //Console.WriteLine();

            //Console.WriteLine("--- Running Synchronously");
            //result = Program.ProcessJob(10);
            //Console.WriteLine("Returned: {0}", result);
            //Console.WriteLine();

            //Console.WriteLine("--- Running Synchronously using the Task Object");
            //result = Program.ProcessJobUsingTask(20);
            //Console.WriteLine("Returned: {0}", result);
            //Console.WriteLine();

            Console.WriteLine("--- Running Asynchronously using Tasks");
            Task<bool> retVal2 = Program.ProcessJobAsync(100);
            Console.WriteLine("printing something asynchronously..... Result will be displayed once available...");
            Console.WriteLine("Printing numbers on Thread {0}", Thread.CurrentThread.ManagedThreadId);
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                Console.Write("{0} ", i);
            }
            retVal2.Wait();
            result = retVal2.Result;
            Console.WriteLine("Returned: {0}", result);
            Console.WriteLine();
        }

        private static bool ProcessJobUsingTask(int i)
        {
            Console.WriteLine("\n-- ProcessJobUsingTask called on Thread {0}", Thread.CurrentThread.ManagedThreadId);

            Task<bool> t = new Task<bool>(() => Program.ProcessJob(i));
            t.Start();
            // t.Wait();
            return t.Result;            // t.Wait() is called implicitly to return the result.
        }

        private static async Task<bool> ProcessJobAsync(int i)
        {
            Console.WriteLine("-- ProcessJobAsync called on Thread {0}", Thread.CurrentThread.ManagedThreadId);

            //--- await for the Task to run, and return the returned value from the Task
            return await Task.Run(() => ProcessJob(i));         // SAME as what is done in ProcessJobUsingTask()
        }

        private static bool ProcessJob(int i)
        {
            Thread.Sleep(5000);         // 5 seconds

            Console.WriteLine("ProcessJob called with i = {0} on Thread: {1}",
                i, Thread.CurrentThread.ManagedThreadId);

            return true;
        }
    }
}