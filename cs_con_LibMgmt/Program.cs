using System;

namespace cs_con_LibMgmt
{
    // GoF Patterns: Design Patterns (Creational, Structural, Behavioral)
    internal class Program
    {
        static void Main(string[] args)
        {
            Library objLib = new Library("Lena Dena Library");
            objLib.Add(new Book("Experiments with Truth", 5, "Mahatma Gandhi", "Mohandas Karamchand Gandhi"));
            objLib.Add(new Book("My demo book", 10, "somebody"));
            objLib.Add(new Book("Another Book"));
            objLib.Add(new Newspaper("Times of India", DateTime.Today));
            objLib.Add(new Newspaper("The Hindu", DateTime.Now.AddDays(-1)));
            objLib.Add(new Newspaper("Times of India", new DateTime(2022, 8, 1)));

            objLib.DisplayLibraryItems();
            Console.WriteLine();

            objLib.Borrow(1, "Manoj");
            objLib.Borrow(4, "Sharma");
            objLib.Borrow(1, "Kumar");
            Console.WriteLine();

            objLib.DisplayLibraryItems();
            Console.WriteLine();

            Console.WriteLine("========================================");
            var item = objLib[1];
            Console.WriteLine(item);

            Console.WriteLine("========================================");

            objLib.Return(1, "Manoj");
            objLib.DisplayLibraryItems();
            Console.WriteLine();

        }
    }
}
