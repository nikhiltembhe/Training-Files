using System;

namespace cs_con_TypeMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MyStructure objStruct;
            MyStructure objStruct = new MyStructure();          // MyStructure has private members!
            objStruct.Id = 10;
            // objStruct.Name = "First object";
            objStruct.SetName("First object");
            objStruct.Price = 500M;

            // MyStructure objStruct2;                          // Compiler Error!
            MyStructure objStruct2 = new MyStructure();         // MyStructure has private members!
            objStruct2.Id = -500;
            // objStruct2.Name = "Second object";
            objStruct2.SetName("Second object");
            objStruct2.Price = 600M;

            Console.WriteLine("objStruct  ---  ID: {0} Name: {1}", objStruct.Id, objStruct.GetName());
            Console.WriteLine("objStruct2 ---  ID: {0} Name: {1}", objStruct2.Id, objStruct2.GetName());

            Console.WriteLine();
            objStruct.SetId(-500);
            Console.WriteLine("objStruct  ---  ID: {0} Name: {1}", objStruct.Id, objStruct.GetName());
            Console.WriteLine("objStruct  ---  ID: {0} Name: {1}", objStruct.GetId(), objStruct.GetName());


            objStruct.Id++;                             // working with Data Field
            objStruct.SetId(objStruct.GetId() + 1);     // working with Method 
            objStruct.Price += 10;                      // working with Property
        }
    }
}
