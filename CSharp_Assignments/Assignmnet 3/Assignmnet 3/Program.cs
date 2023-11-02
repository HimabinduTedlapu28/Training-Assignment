using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmnet_3
{
    class Program
    {
        static void Main()
        {

            Console.Write(" Enter the First Word : ");
            string a = Console.ReadLine();
            Console.WriteLine(" Enter the second word : ");
            string b = Console.ReadLine();
            if (a == b)
            {
                Console.WriteLine("Both are same");
            }
            else
            {
                Console.WriteLine("Both are not same");
            }
            Console.ReadLine();

        }
    }
}
