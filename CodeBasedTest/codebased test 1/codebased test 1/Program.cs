using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebased_test_1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number : ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Enter the limit for the multiplication table : ");
            int limit = int.Parse(Console.ReadLine());
            Console.WriteLine($" multiplication table for {number} up to {limit}: ");
            for (int i =1; i<= limit; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }
            Console.ReadLine();

        }
    }
}
