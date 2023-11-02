using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class Operations
    {
        static void Main()
        {
            Console.WriteLine(" Enter a Number :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the SEcond NUmber :");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            int difference = num1 - num2;
            int product = num1 * num2;
            float divide = num1 / num2;
            Console.WriteLine($"sum: {sum}");
            Console.WriteLine($"diff : {difference}");
            Console.WriteLine($"product : {product}");
            Console.WriteLine($"Divide : { divide}");
            Console.ReadLine();



        }
    }
}
