using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casestudyproject
{
    public class Info
    {
        

        public void DisplayCourse(Course course)
        {
            Console.WriteLine($"Course Code: {course.courseid}");
            Console.WriteLine($"Course Name: {course.coursename}");
            Console.WriteLine();
        }

        
        public static  void DisplayStudent(Student student)
        {
            Console.WriteLine($"Student ID: {student.Id}");
            Console.WriteLine($"Student Name: {student.Name}");
            Console.WriteLine($"Date of Birth: {student.Dateofbirth}");
        }
        public static void DisplayEnrollmentDetails(Enroll enrollment)
        {
            Console.WriteLine($"Student: {enrollment.student.Name}");
            Console.WriteLine($"Course: {enrollment.course.coursename}");
            Console.WriteLine($"Enrollment Date: {enrollment.Enrollmentdate}");
        }

        
    }
}
