using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebased_4
{
    class question1
    {
        static void Main(string[] args)
        {
            
            
                string filePath = "C:\\CodeBasedTest\\codebased 4.txt"; 

                try
                {

                    if (File.Exists(filePath))
                    {
                        using (StreamWriter createFile = File.CreateText(filePath))
                        {
                            Console.WriteLine("File created successfully.");
                        }
                    }



                    using (StreamWriter writer = File.AppendText(filePath))
                    {
                        writer.WriteLine("This is a new line of text.");
                        writer.WriteLine("Appending more text.");
                        Console.WriteLine("Text appended successfully.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

            
         }
    }



}
        



     