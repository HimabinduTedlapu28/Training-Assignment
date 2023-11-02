using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01
{
    class Check
    {
        public static void calc()
        {
            int num;
            Console.Write("\n\n");
            Console.WriteLine("Enter the number :");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
                Console.WriteLine("{0} is a Positive Number. \n", num);
            else
                Console.WriteLine("It is a Negative Number. \n", num);
            Console.ReadLine();

        }
    }
}
