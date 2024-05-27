using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_InterfacesExtended.Demo04
{
    interface IDemo
    {
        void m();
    }

    interface IAnotherDemo
    {
        void m();
    }

    interface IDifferentDemo
    {
        void m();
    }


    // Demo of Implicit Implementation of the Interface Signature
    class Demo : IDemo, IAnotherDemo, IDifferentDemo
    {
        public void m()
        {

        }
    }


    // Demo of Explicit Implementation of the Interface Signatures.
    class Demo2 : IDemo, IAnotherDemo, IDifferentDemo
    {
        // Explicitly implemented Interface Signature
        // 1. NO ACCESS MODIFIER (public)
        // 2. Name of the Interface should be included in the Member implementation.
        void IDemo.m()
        {
            Console.WriteLine("m() implemented explicitly in accordance to IDemo interface");
        }

        // Explicitly implemented Interface Signature
        void IAnotherDemo.m()
        {
            Console.WriteLine("m() implemented explicitly in accordance to IAnotherDemo interface");
        }

        // Implicitly implemented Interface Signature
        public void m()         // IDifferentDemo.m()
        {
            Console.WriteLine("m() implemented implicitly");
        }

    }

    class RunThis
    {
        public static void Run()
        {
            Demo04.Demo2 obj = new Demo2();
            obj.m();                        // implicitly implemented method
            (obj as IDemo).m();             // explicitly implemented IDemo.m()
            (obj as IAnotherDemo).m();      // explicitly implemented IAnotherDemo.m();
            (obj as IDifferentDemo).m();    // implicitly implemented method of IDifferentDemo.m();
            Console.WriteLine();

            IDemo obj2 = new Demo();        
            obj2.m();                       // explicitly implemented IDemo.m()
            (obj2 as Demo).m();             // implicitly implemented method
            (obj2 as IAnotherDemo).m();     // explicitly implemented IAnotherDemo.m();
        }
    }
}
