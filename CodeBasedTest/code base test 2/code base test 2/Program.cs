using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code_base_test_2
{
    class Program
    {
        
    


        abstract class Student
        {
            public string Name { get; set; }
            public int StudentId { get; set; }
            public double Grade { get; set; }

            public abstract bool IsPassed(double grade);
        }

        class Undergraduate : Student
        {
            public override bool IsPassed(double grade)
            {
                return grade >= 70.0;

            }
        }

        class Graduate : Student
        {
            public override bool IsPassed(double grade)
            {
                return grade >= 80.0;
            }
        }

        class Program2

        {
            static void Main()
            {
                Console.WriteLine(" Enter the name :  ");
                string name = Console.ReadLine();
                Console.ReadLine();
                Console.WriteLine("Enter the grade : ");
                int grade = Convert.ToInt32(Console.ReadLine());



                Student undergraduateStudent = new Undergraduate
                {

                    Name = "Harsha",
                    StudentId = 89715,
                    Grade = 75.0
                };


                bool passedUndergraduate = undergraduateStudent.IsPassed(undergraduateStudent.Grade);
                Console.WriteLine($"{undergraduateStudent.Name} {(passedUndergraduate ? "passed" : "did not pass")} as an undergraduate student.");

                Console.WriteLine(" Enter the name :  ");
                string name1 = Console.ReadLine();
                Console.ReadLine();
                Console.WriteLine("Enter the grade : ");
                int grade1 = Convert.ToInt32(Console.ReadLine());



                Student graduateStudent = new Graduate
                {
                    Name = " Ajay",
                    StudentId = 5460,
                    Grade = 85.0
                };


                bool passedGraduate = graduateStudent.IsPassed(graduateStudent.Grade);
                Console.WriteLine($"{graduateStudent.Name} {(passedGraduate ? "passed" : "did not pass")} as a graduate student.");
                Console.ReadLine();
            }






        }


    }


}

