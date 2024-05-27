using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_DelegatesMultiCast
{
    internal class Program
    {
        delegate void StepHandler();

        static void Main(string[] args)
        {
            Process p = new Process();

            // objD1 = Single-Cast Delegate (delegate is pointing ONLY TO ONE method that needs to be invoked)
            StepHandler objD1;
            objD1 = new StepHandler(p.Step01);       // subscribe to p.Step01()
            objD1();            // invoking the delegate
            Console.WriteLine();

            // objD2 = Multi-Cast Delegate (delegate is pointing to MULTIPLE methods that needs to be invoked) 
            StepHandler objD2;
            objD2 = new StepHandler(p.Step01);      // subscribe to p.Step01()
            objD2 += new StepHandler(p.Step02);     // subscribe to p.Step02()
            objD2();            // invoking the delegate
            Console.WriteLine();


            StepHandler product1Steps;
            product1Steps = new StepHandler(p.Step01);
            product1Steps += new StepHandler(p.Step03);
            product1Steps += new StepHandler(p.Step02);
            product1Steps += new StepHandler(p.Step03);
            product1Steps += new StepHandler(p.Step04);
            product1Steps += new StepHandler(p.Step10);

            Console.WriteLine("Invoke the Product #1 Steps!");
            product1Steps();
            Console.WriteLine();



            StepHandler objD;
            GenerateProduct02(out objD);        // Factory Method Pattern
            Console.WriteLine("Invoke the Product #2 Steps!");
            objD();
            Console.WriteLine();

            Console.WriteLine("Adding another additional step - Step 05, 07");
            objD += new StepHandler(p.Step05);      // Subscribing method to delegate
            objD += new StepHandler(p.Step07);
            objD();
            Console.WriteLine();

            Console.WriteLine("Removing a duplicate step - Step 05");
            objD -= new StepHandler(p.Step05);      // Unsubscribing method from the delegate (LIFO Pattern)
            objD();
            Console.WriteLine();
        }

        // Design Pattern: Factory Method Pattern
        static private void GenerateProduct02(out StepHandler objD)
        {
            Process p = new Process();

            objD = new StepHandler(p.Step01);
            objD += new StepHandler(p.Step02);
            objD += new StepHandler(p.Step05);
            objD += new StepHandler(p.Step07);
            objD += new StepHandler(p.Step10);
        }

    }
}
