using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_con_Generics
{
    class MyGenericType<T>
    {
        public T Value { get; set; }

        public void m()
        {
            Console.WriteLine($"m() called for the Value = {this.Value}");
        }

        public void n()
        {
            Console.WriteLine("n() called!");
        }
    }
}
