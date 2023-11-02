using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebased_test_1
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine(test("Python", 1));
            Console.WriteLine(test("Python", 0));
            Console.WriteLine(test("Python", 4));
            Console.ReadLine();
          
        }
         static string test( string str, int n)
        {
            return str.Remove(n, 1);
        }
            

        
    }
}
