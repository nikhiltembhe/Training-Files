using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

namespace cs_con_Parallel
{
    // Demo of TPL: Task Parallel Library

    internal class Program
    {
        private static void displayNumber(int i)
        {
            Thread.Sleep(100);         // 100 milliseconds
            Console.WriteLine("i = {0} on Thread: {1}", i, Thread.CurrentThread.ManagedThreadId);
        }

        private static void Demo01(Stopwatch stopwatch, int[] arr)
        {
            stopwatch.Restart();
            foreach (int i in arr)
            {
                displayNumber(i);
            }
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} milliseconds [ {1} ] ",
                stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);

            Console.WriteLine();
        }

        private static void Demo02(Stopwatch stopwatch, int[] arr)
        {

            stopwatch.Restart();
            //foreach (int i in arr)
            //{
            //    displayNumber(i);
            //}

            //  (running Parallelly for each element in array)
            Parallel.ForEach(arr, i =>
            {
                displayNumber(i);
            });
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} milliseconds [ {1} ] ",
                stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);

            Console.WriteLine();
        }

        static void Demo03(Stopwatch stopwatch, int[] arr)
        {
            stopwatch.Restart();
            for (int i = 0; i < arr.Length; i++)
            {
                displayNumber(arr[i]);
            }
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} milliseconds [ {1} ] ",
                stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);

            Console.WriteLine();
        }

        static void Demo04(Stopwatch stopwatch, int[] arr)
        {
            stopwatch.Restart();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    displayNumber(arr[i]);
            //}
            Parallel.For(fromInclusive: 0, toExclusive: arr.Length, i =>
            {
                displayNumber(arr[i]);
            });
            stopwatch.Stop();
            Console.WriteLine("Elapsed Time: {0} milliseconds [ {1} ] ",
                stopwatch.ElapsedMilliseconds, stopwatch.ElapsedTicks);
            Console.WriteLine();

        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("---- Synchronous version of the ForEach Loop");
            Demo01(stopwatch, arr);

            Console.WriteLine("---- Asynchronous Version of the ForEach Loop using Parallel.ForEach");
            Demo02(stopwatch, arr);

            Console.Write("Press any key to continue....");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");

            Console.WriteLine("--- Synchronous version of the FOR LOOP");
            Demo03(stopwatch, arr);

            Console.WriteLine("--- ASynchronous version of the FOR LOOP using Parallel.For");
            Demo04(stopwatch, arr);
        }

    }
}
