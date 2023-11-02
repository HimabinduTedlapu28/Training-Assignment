using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebased_4
{
   

        delegate int CalculatorOperation(int num1, int num2);

        class question2
        {
            static void Main(string[] args)
            {
                
                CalculatorOperation add = (a, b) => a + b;
                CalculatorOperation subtract = (a, b) => a - b;
                CalculatorOperation multiply = (a, b) => a * b;

                while (true)
                {
                    Console.WriteLine("Calculator Menu:");
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice (1/2/3/4): ");

                    if (int.TryParse(Console.ReadLine(), out int choice))
                    {
                        if (choice == 4)
                        {
                            break;
                        }
                        else if (choice >= 1 && choice <= 3)
                        {
                            Console.Write("Enter the first number: ");
                            if (int.TryParse(Console.ReadLine(), out int num1))
                            {
                                Console.Write("Enter the second number: ");
                                if (int.TryParse(Console.ReadLine(), out int num2))
                                {
                                    int result = 0;

                                    
                                    switch (choice)
                                    {
                                        case 1:
                                            result = add(num1, num2);
                                            Console.WriteLine($"Result of addition: {result}");
                                            break;
                                        case 2:
                                            result = subtract(num1, num2);
                                            Console.WriteLine($"Result of subtraction: {result}");
                                            break;
                                        case 3:
                                            result = multiply(num1, num2);
                                            Console.WriteLine($"Result of multiplication: {result}");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid second number. Please enter a valid integer.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid first number. Please enter a valid integer.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice. Please enter 1, 2, 3, or 4.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                }
            }
        }







    


}






    
}
