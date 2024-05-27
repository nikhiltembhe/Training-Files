using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 10, 20, 30, 40, 50 };
            int secondItem = arr[1];            // GET Accessor of the Indexer
            arr[3] = secondItem + 10;           // SET Accessor of the Indexer

            MyData obj = new MyData();
            obj.DisplayNames();

            obj.FirstName = obj.FirstName.ToUpper();            // Property
            obj.DisplayNames();

            //string secondname = obj.GetName(1);
            //obj.SetName(1, secondname.ToUpper());
            obj.SetName(1, obj.GetName(1).ToUpper());           // Method
            obj.DisplayNames();

            // obj._names[2] = obj._names[2].ToUpper();
            obj[2] = obj[2].ToUpper();                          // Indexer
            obj.DisplayNames();


            string s = "Hello world";
            char secondChar = s[1];             // 'e'

            Console.WriteLine("Before changing, s = {0}", s);
            // s[1] = 'x';              // String is immutatable (cannot be changed internally!)
            s = s.Replace('e', 'x');
            Console.WriteLine("After changing, s = {0}", s);

        }
    }
}
