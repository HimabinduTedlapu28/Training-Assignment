using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebase3
{
    // Write a program to find the Sum and the Average points scored by the teams in the IPL.Create a Class called Cricket that has a function called Pointscalculation(int no_of_matches) that takes no.of matches as input and accepts that many scores from the user.The function should then display the Average and Sum of the scores.
    
   class cricket
    {
        public void Pointscalculation(int no_of_matches)
        {

            int[] scores = new int[no_of_matches];
            for (int i = 0; i < no_of_matches; i++)
            {
                Console.WriteLine(" Enter the score :" + (i + 1));
                if (int.TryParse(Console.ReadLine(), out int score))
                {
                    scores[i] = score;
                }
                else
                {
                    Console.WriteLine("Invalid data ");
                }
            }
            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }
            double average = (double)sum / no_of_matches;
            Console.WriteLine($"Total Sum of Scores: {sum}");
            Console.WriteLine($"Average Score: {average:F2}");
            Console.ReadLine();
        }
    }
    class cricket1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of IPL matches: ");
            if (int.TryParse(Console.ReadLine(), out int no_of_matches) && no_of_matches > 0)
            {
                cricket Cricket = new cricket();
                Cricket.Pointscalculation(no_of_matches);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number of matches.");
            }
            Console.ReadLine();
        }
    }


}
    

