using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;
using System.Threading.Tasks;

namespace cs_con_Tasks
{
    internal class Demo03
    {
        private static void DoSomething()
        {
            Console.WriteLine("\tDoSomething called on Thread: {0}", Thread.CurrentThread.ManagedThreadId);
        }

        public static void Run()
        {
            Task t1 = Task.Factory.StartNew(Demo03.DoSomething);
            Task t2 = Task.Factory.StartNew(Demo03.DoSomething);
            Task t3 = Task.Factory.StartNew(Demo03.DoSomething);

            // Wait for all the tasks to complete.
            Task.WaitAll(t1, t2, t3);

            Console.WriteLine("--- finished the first three tasks!");
            Console.WriteLine();

            
            
            // Fluid Code / Chain Calls (execute next after the previous task has completed)
            var factory = Task.Factory.StartNew(Demo03.DoSomething)
                                      .ContinueWith((t) =>
                                      {
                                          Console.WriteLine("\tContinued into Step 2 on Thread: {0}",
                                              Thread.CurrentThread.ManagedThreadId);
                                      })
                                      .ContinueWith((t) =>
                                      {
                                          Console.WriteLine("\tContinued again into Step 3 on Thread: {0}",
                                              Thread.CurrentThread.ManagedThreadId);
                                      })
                                      .ContinueWith( (t) => {
                                          Console.WriteLine("\tFinally Continued to Step 4 on Thread: {0}",
                                              Thread.CurrentThread.ManagedThreadId);
                                      });

            factory.Wait();
        }

    }
}
