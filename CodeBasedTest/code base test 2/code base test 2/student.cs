using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace code_based__test__2
    {
        class Program
        {




            class Product : IComparable<Product>
            {
                public int ProductId { get; set; }
                public string ProductName { get; set; }
                public double Price { get; set; }

                public int CompareTo(Product other)
                {
                    return Price.CompareTo(other.Price);
                }
            }
            class Program1
            {
                static void Main()
                {
                    Product[] products = new Product[10];


                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine($"Enter details for Product {i + 1}:");
                        Console.Write("Product ID: ");
                        int productId = int.Parse(Console.ReadLine());
                        Console.Write("Product Name: ");
                        string productName = Console.ReadLine();
                        Console.Write("Price: ");
                        double price = double.Parse(Console.ReadLine());

                        products[i] = new Product
                        {
                            ProductId = productId,
                            ProductName = productName,
                            Price = price
                        };
                    }


                    Array.Sort(products);


                    Console.WriteLine("\nSorted Products by Price:");
                    foreach (var product in products)
                    {
                        Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Price: {product.Price:C}");
                        Console.ReadLine();
                    }
                }
            }






        }








    }





                






        








    
























