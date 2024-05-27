using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace cs_con_Tasks
{
    internal class Demo01
    {
        public static void Run()
        {
            int x = 0;

            //Thread t1 = new Thread(new ThreadStart(() => {
            //    Console.WriteLine("\tThread: {0} called!", Thread.CurrentThread.ManagedThreadId);
            //}));
            //t1.Start();
            //t1.Join();

            //Thread t2 = new Thread(new ParameterizedThreadStart((obj) => {
            //    Console.WriteLine("\tThread: {0} called!", Thread.CurrentThread.ManagedThreadId);
            //}));
            //t2.Start();
            //t2.Join();

            ThreadStart objD = new ThreadStart(
                () =>
                {
                    Console.WriteLine("\tThread: {0} going to sleep!", Thread.CurrentThread.ManagedThreadId);
                    Thread.Sleep(5000);             // 5 seconds
                    x = 200;
                    Console.WriteLine("\tThread: {0} woke up!", Thread.CurrentThread.ManagedThreadId);
                });
            Thread t = new Thread(objD);
            t.Start();

            Console.WriteLine("Waiting for the child thread to complete.....");
            Console.WriteLine("x = {0}", x);
            t.Join();
            Console.WriteLine("x = {0}", x);

            Console.WriteLine("....COMPLETED");  
        }

    }
}
