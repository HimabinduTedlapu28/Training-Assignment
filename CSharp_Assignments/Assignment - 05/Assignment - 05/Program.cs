using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___05
{
    class name
    {
        static void Main()
        {
            
                Console.Write("Enter First Name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                string lastName = Console.ReadLine();

                Display(firstName, lastName);

                
                Console.ReadLine();
        }

            static void Display(string firstName, string lastName)
            {
                string upperFirstName = firstName.ToUpper();
                string upperLastName = lastName.ToUpper();

                Console.WriteLine(upperFirstName);
                Console.WriteLine(upperLastName);
            Console.ReadLine();
            }
        
    }
        










        






}

