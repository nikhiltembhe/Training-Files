using System;
using System.Collections.Generic;
using System.Text;

namespace cs_con_Assignment02
{
    internal class Product
    {
        private static int productIdCounter;

        static Product()
        {
            Product.productIdCounter = 100;
        }

        public Product()
        {
            this._ProductId = ++Product.productIdCounter;
        }

        private int _ProductId;
        public int ProductId
        {
            get
            {
                return _ProductId;
            }
        }

        public string ProductName { get; set; } 

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public decimal Cost
        {
            get
            {
                return Price * Quantity;
            }
        }

        public override string ToString()
        {
            return $"{ProductId, 5} {ProductName,-20} {Quantity,5} {Price,15:C} {Cost, 15:C}";
        }
    }
}
