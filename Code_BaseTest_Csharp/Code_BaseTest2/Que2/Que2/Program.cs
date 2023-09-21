using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebasetest._2_2ndprog
{

    class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[10];

            // Accept details for 10 products
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine($"Enter details for Product {i + 1}:");

                Console.Write("Product ID: ");
                int productId = int.Parse(Console.ReadLine());

                Console.Write("Product Name: ");
                string productName = Console.ReadLine();

                Console.Write("Price: ");
                decimal price = decimal.Parse(Console.ReadLine());

                products[i] = new Product
                {
                    ProductId = productId,
                    ProductName = productName,
                    Price = price
                };
            }

            // Sort the products by price using a simple bubble sort
            for (int i = 0; i < products.Length - 1; i++)
            {
                for (int j = 0; j < products.Length - i - 1; j++)
                {
                    if (products[j].Price > products[j + 1].Price)
                    {
                        // Swap the products
                        Product temp = products[j];
                        products[j] = products[j + 1];
                        products[j + 1] = temp;
                    }
                }
            }

            // Display the sorted products
            Console.WriteLine("\nSorted Products by Price:");

            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductId}");
                Console.WriteLine($"Product Name: {product.ProductName}");
                Console.WriteLine($"Price: {product.Price:C2}");
                Console.WriteLine();
            }
        }
    }



}


