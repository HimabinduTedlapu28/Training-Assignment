using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONCESSION
{
    public class concessioncalculator
    {
        
            public const int TotalFare = 500;

            public string Name { get; set; }
            public int Age { get; set; }

            public void CalculateConcession()
            {
                if (Age <= 5)
                {
                    Console.WriteLine($"Little Champs - Free Ticket | Name: {Name}, Age: {Age}");
                }
                else if (Age > 60)
                {
                    double concessionAmount = 0.3 * TotalFare;
                    double discountedFare = TotalFare - concessionAmount;
                    Console.WriteLine($"Senior Citizen - {discountedFare:C2} | Name: {Name}, Age: {Age}");
                }
                else
                {
                    Console.WriteLine($"Ticket Booked - {TotalFare:C2} | Name: {Name}, Age: {Age}");
                }
            }
        
    }
}
    
   





                   
   
    
















  