using System;

namespace cs_con_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList intList = new System.Collections.ArrayList();

            // BOXING because the .Add(object item)
            intList.Add(10);                    // intList[0] == 10
            intList.Add(20);                    // intList[1] == 20
            intList.Add(30);                    // intList[2] == 30

            intList.Add("hello world");         // intList[3] == "hello world"
            intList.Add(false);                 // intList[4] == false

            Console.WriteLine(intList[3]);      // "hello world"

            Console.WriteLine("Length of ArrayList: {0}", intList.Count);       // 6

            intList.Add(new int[] { 100, 200, 300 });       // intList[5] = { 100, 200, 300 }

            int[] arr = intList[5] as int[];
            int secondItem = arr[1];
            Console.WriteLine(secondItem);
            Console.WriteLine((intList[5] as int[])[1]);

            Console.WriteLine("Length of the array: {0}", arr.Length);
            Console.WriteLine("Length of ArrayList after adding the array using Add: {0}", intList.Count);       // 6

            intList.RemoveAt(1);            // removes the item in second position      // Length: 5

            intList.AddRange(new int[] { 1000, 2000, 3000 });   // intList[5] = 10000, intList[6] = 2000, ...

            Console.WriteLine("Length of ArrayList after adding the array using AddRange : {0} ", intList.Count);       // 6

            Console.WriteLine();
            foreach(var item in intList)
            {
                Console.WriteLine("Type: {0}, Value = {1}", item.GetType(), item);
            }
        }
    }
}
