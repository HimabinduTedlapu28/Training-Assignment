using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
    class UserInterface
    {
        public static void Main()
        {
            FirstScreen();
            Console.Read();
        }
        public static void FirstScreen()
        {

            Console.WriteLine("Welcome to SMS");
            
            Console.WriteLine("Choose one of the choice from below options:");
            Console.WriteLine("1.Admin login");
            Console.WriteLine("2.Student login");
            Console.WriteLine("3.Exit");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        AdminScreen();
                        break;
                    case 2:
                        StudentScreen();
                        break;
                    case 3:
                        Console.WriteLine("Thankyou for visiting SMS!!!!");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice entered.....Choose one from (1/2/3)");
                        break;
                }
            }

        }
        public static void StudentScreen()
        {
            Console.WriteLine("--------You are in Student Screen---------");
            Console.WriteLine("1.Enroll a student");
            Console.WriteLine("2.Show list of courses");
            Console.WriteLine("3.Back to main menu");
            Console.WriteLine("Enter your choice:");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You are enrolling a new student.......");
                        Console.WriteLine("---------------------------------------------------------------");
                        var studs = AppEngine.GetStudents();
                        foreach (var s in studs)
                        {
                            Console.WriteLine($"{s.studentID}    {s.studentName}   {s.studentDOB:yyyy-MM-dd}");

                        }
                        
                        
                        Console.WriteLine("Remember the student ID corresponding to your name from the above table" +
                            "......If your name is not in table.....contact Admin and ask to add your name to database..........:");
                        Console.WriteLine("Enter Student ID:");
                        if (int.TryParse(Console.ReadLine(), out int StudentID))
                        {
                            var stud = AppEngine.Retrievestudent(StudentID);
                            if (stud != null)
                            {
                                Console.WriteLine("All Courses:");
                                var course = AppEngine.GetCourses();
                                foreach (var c in course)
                                {
                                    Console.WriteLine($"ID:{c.CourseID}, Name:{c.CourseName}");
                                }
                                Console.WriteLine("Enter Course ID to enroll in that particular course:");
                                int CourseID;
                                if (int.TryParse(Console.ReadLine(), out CourseID))
                                {
                                    var c = AppEngine.RetrieveCourse(CourseID);
                                    if (c != null)
                                    {
                                        AppEngine.EnrollStudent(stud.studentID, c.CourseID);
                                        Console.WriteLine($"{stud.studentName} enrolled in {c.CourseName}");

                                    }
                                    else
                                    {
                                        Console.WriteLine("Course not found........");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid CourseID");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid StudentID");
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("List of courses are:");
                        var courses = AppEngine.GetCourses();
                        foreach (var c in courses)
                        {
                            Console.WriteLine($"ID:{c.CourseID},Name:{c.CourseName}");
                        }
                        Console.WriteLine(" back to student menu.....");
                        Console.ReadKey();
                        StudentScreen();
                        break;
                    case 3:
                        FirstScreen();
                        break;


                }
            }
        }
        public static void AdminScreen()
        {
            Console.WriteLine(" Admin Screen");
            Console.WriteLine("1.Add a new student to database");
            Console.WriteLine("2.See the list of students in database");
            Console.WriteLine("3.Add a new Course");
            Console.WriteLine("4.See the list of courses ");
            Console.WriteLine("5.Back to Main Menu");
            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        Student stud = new Student();
                        stud.AddStudentDetails();
                        Console.WriteLine("Student Added successfully!!!");
                        Console.WriteLine("Press any key to return to the Admin Menu...");
                        Console.ReadKey();
                        AdminScreen();
                        break;
                    case 2:
                        Console.WriteLine("List of all students");
                        var studs = AppEngine.GetStudents();
                        foreach (var s in studs)
                        {
                            Console.WriteLine($"{s.studentID}    {s.studentName}   {s.studentDOB:yyyy-MM-dd}");

                        }
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("You are here to add a new Course");
                        Course course = new Course();
                        course.AddCourse();
                        Console.WriteLine("Addition Successfull");
                        break;
                    case 4:
                        Console.WriteLine("List of Courses");
                        var courses = AppEngine.GetCourses();
                        foreach (var c in courses)
                        {
                            Console.WriteLine($"ID:{c.CourseID},Name:{c.CourseName}");
                        }
                        Console.WriteLine(" Admin Menu");
                        Console.ReadKey();
                        AdminScreen();
                        break;
                    
                    case 5:
                        FirstScreen();
                        break;
                }
            }
        }
    }
}