using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___05
{
    class count
    {
        public static int i;
        public static int Count( string a, char b)
        {
            int count = 0;

            for (int i = 0; i < a.Length; i++) ;
            {
                if (a[i] == b)



                    count++;
                

            }
            return count;


        }
        public static void Main()
        {

        

            Console.WriteLine(" Enter the word : ");
            string word = Console.ReadLine();
            Console.WriteLine("Enter the letter to repeat");
            Char b = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("+b"  + "occurs" +Count(word,b) + "times");
            Console.ReadLine();


        }
    }
}
