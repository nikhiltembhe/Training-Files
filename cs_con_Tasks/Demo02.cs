using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;
using System.Threading.Tasks;

namespace cs_con_Tasks
{
    internal class Demo02
    {
        public static void Run()
        {
            Task t = Task.Factory.StartNew(
                () =>
                {
                    Console.WriteLine("\tThread: {0} going to sleep!", Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(5000);
                    Console.WriteLine("\tThread: {0} woke up!", Thread.CurrentThread.ManagedThreadId);
                });


            Console.WriteLine("Waiting for the child thread to complete.....");
            Task.WaitAll(t);
            Console.WriteLine("....COMPLETED");
        }
    }
}
