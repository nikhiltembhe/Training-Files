using System;

namespace cs_con_DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte l = 15;            // 1 byte (8 bits) (min: 0, max: 255)
            short j = 11;           // System.Int16 j = 11;
            int i = 10;             // System.Int32 i = 10;
            long k = 12;            // System.Int64 k = 12;

            Console.WriteLine($"byte l = {l} \tType = {l.GetType()}");
            Console.WriteLine($"short j = {j} \tType = {j.GetType()}");
            Console.WriteLine("int i = {0} \tType = {1}", i, i.GetType());
            Console.WriteLine($"long k = {k} \tType = {k.GetType()}");
            Console.WriteLine();

            string s = "Hello world";
            char c = 'T';

            DateTime dt = DateTime.Now;
            Console.WriteLine($"Current Date Time: {dt}");
            Console.WriteLine($"Current Date Time: {dt.ToString("dd-MMM-yyyy")}");
            Console.WriteLine($"Current Date Time: {dt.ToString("dddd dd-MMMM-yyyy hh:mm:ss tt")}");
            Console.WriteLine();


            // Value-Type
            MyStructure objStruct;                          // Declaration & Instantiation (implicit)
            objStruct.ID = 10;                              // Initializing the member - ID
            objStruct.Name = "First Structure Object";      // Initializing the member - Name
            objStruct.CompanyName = "Microsoft";            // Initializing the member - CompanyName

            // Reference-Type
            MyClass objClass = new MyClass();               // Declaration & Instantiation (explicit)
            objClass.ID = 20;                               // Initializing the member - ID
            objClass.Name = "First Class Object";           // Initializing the member - Name
            objClass.CompanyName = "Microsoft";             // Initializing the member - CompanyName

        }
    }
}