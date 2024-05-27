using System;

namespace cs_con_Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop("My Grocery Store");

            int menu = -1;
            while (menu != 0)
            {
                Console.WriteLine("MENU for {0}", shop.ShopName);
                Console.WriteLine("1. Add a product");
                Console.WriteLine("2. Display all products");
                Console.WriteLine("3. Remove a product");
                Console.WriteLine("0  EXIT");
                Console.Write("Enter your choice: ");
                string menuInput = Console.ReadLine();
                int.TryParse(menuInput, out menu);

                switch (menu)
                {
                    case 0:
                        Console.WriteLine("--- Thank you");
                        break;
                    case 1:
                        shop.AddProduct();
                        break;
                    case 2:
                        Console.WriteLine();
                        shop.DisplayAllProducts();
                        break;
                    case 3:
                        shop.RemoveProduct();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }           // while(true)
        }
    }
}
