using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = new int[50];
            int sum = 0;
            float avg;
            Console.WriteLine("Enter the size :");
            int len = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter" + len + " elements :");
            for (int i = 0; i < len; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i <  len; i++ )
            {
                sum += numbers[i];

            }
            avg = sum / len;
            Console.WriteLine(" Average is :" + avg);
            int min = numbers[0];
            int max = numbers[0];
            for ( int i = 0;i < len; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
                else if (numbers[i] < min)
                    min = numbers[i];
            }
            Console.WriteLine(" max : ", +max);
            Console.WriteLine(" min :", +min);
            Console.ReadLine();
            
            
                
            
        }
    }
}
