using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace cs_con_Assignment02
{
    internal class Shop
    {
        // Aggregated Collection of Objects
        private ArrayList products;

        public string ShopName { get; private set; }

        public Shop(string name)
        {
            this.ShopName = name;
            products = new ArrayList();
        }

        public void AddProduct()
        {
            Product product = new Product();

            Console.WriteLine();
            Console.WriteLine("Enter the details of the Product");
            Console.Write("Product Name : ");
            product.ProductName = Console.ReadLine();
            Console.Write("Quantity : ");
            product.Quantity = int.Parse(Console.ReadLine());
            Console.Write("Price : ");
            product.Price = decimal.Parse(Console.ReadLine());

            this.products.Add(product);                         // boxing
        }

        public void RemoveProduct()
        {
            this.DisplayAllProducts();
            Console.WriteLine("Enter the ID of the product to remove:");
            int id = int.Parse(Console.ReadLine());
            for (int i = 0; i < products.Count; i++)
            {
                Product p = this.products[i] as Product;        // unboxing
                if(p.ProductId == id)
                {
                    this.products.Remove(p);
                    break;          // exit the for loop
                }
            }
            
        }

        public void DisplayAllProducts()
        {
            Console.WriteLine();
            Console.WriteLine($"List of Products in {this.ShopName.ToUpper()}:");
            Console.WriteLine("{0,5} {1,-20} {2,5} {3,15} {4, 15}", "ID", "Product Name", "Qty", "Price", "Cost");

            foreach (Product p in this.products)
            {
                Console.WriteLine(p);
            }
        }
    }
}
