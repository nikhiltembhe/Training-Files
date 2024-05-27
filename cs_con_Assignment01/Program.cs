using System;
using System.Collections;

namespace cs_con_Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();

            int menu = -1;
            while (menu != 0)
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1. Add a product");
                Console.WriteLine("2. Display all products");
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
                        Product newProduct = GetProductInfo();
                        myList.Add(newProduct);
                        break;
                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("List of Products in my Application:");
                        // Console.WriteLine($"{"ID"} {"Product Name",-20} {"Qty",5}, {"Price",15}");
                        Console.WriteLine("{0} {1,-20} {2,5}, {3,15}", "ID", "Product Name", "Qty", "Price");
                        for (int i = 0; i < myList.Count; i++)
                        {
                            Console.WriteLine((Product)myList[i]);
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }           // while(true)
        }
    
        static Product GetProductInfo()
        {
            Product product;

            Console.WriteLine();
            Console.WriteLine("Enter the details of the Product");
            Console.Write("Product ID : ");
            product.ProductId = int.Parse(Console.ReadLine());
            Console.Write("Product Name : ");
            product.ProductName = Console.ReadLine();
            Console.Write("Quantity : ");
            product.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Price : ");
            product.Price = decimal.Parse(Console.ReadLine());

            return product;
        }
    }
}
