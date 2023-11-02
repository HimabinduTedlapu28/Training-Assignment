using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Casestudyproject
{
   public  class AppEngine
    {
        public static SqlConnection GetConnection()
        {
            return new SqlConnection("Data Source=ICS-LT-CZFBR73;Initial Catalog=sms;" +
                "Integrated Security=True");

        }

        public static List<Student> GetStudents()
        {
            List<Student> student = new List<Student>();
            using (SqlConnection connection = GetConnection())
            {
                string query = "select * from studentinfo";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader sdr = command.ExecuteReader();
                    Console.WriteLine(" ID\t, Name\t, DateofBirth\t");
                   

                    while (sdr.Read())
                    {
                        int studentid = sdr.GetInt32(0);
                        string studentname = sdr.GetString(1);
                        DateTime studentdob = sdr.GetDateTime(2);
                        Console.WriteLine(" studentid\t, studentname\t, studentdob\t");

                    }
                    sdr.Close();
                }
            }
            return student;
        }
        public static List<Course> GetCourses()
        {
            List<Course> course = new List<Course>();
            using (SqlConnection connection = GetConnection())
            {
                string query = "select * from courses";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader sdr = command.ExecuteReader();
                    Console.WriteLine("{0} {1}", "ID", "Course Name");
                    while (sdr.Read())
                    {
                        int courseid = sdr.GetInt32(0);
                        string coursename = sdr.GetString(1);
                        Console.WriteLine("{0} {1}", courseid, coursename);
                    }
                    sdr.Close();
                }
            }
            return course;
        }
        public static void EnrollStudent(int studentID, int courseID)
        {
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    string query = "insert into Enrollments (StudentID,CourseID) values (@StudentID," +
                        "@CourseID)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@studentID", studentID);
                        command.Parameters.AddWithValue("@courseID", courseID);

                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static List<Enroll> GetEnrollments()
        {
            List<Enroll> enrolls = new List<Enroll>();
            try
            {
                using (SqlConnection connection = GetConnection())
                {
                    connection.Open();
                    string query = "select e.StudentID,s.StudentName as studentname, e.CourseID,c.CourseName from Enrollments E" +
                        "join studentdata s on e.StudentID as s.studentID " + "join courses c on e.CourseID=c.CourseID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            int studentid = sdr.GetInt32(0);
                            string studentname = sdr.GetString(1);
                            int courseid = sdr.GetInt32(2);
                            string coursename = sdr.GetString(3);

                            enrolls.Add(new Enroll(studentid, studentname, courseid, coursename));
                        }
                        sdr.Close();
                    }

                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
            }

            return enrolls;


        }
        public static Student Retrievingstudent(int studentID)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "select * from studentdata where StudentID =@studentID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@studentID", studentID);
                    SqlDataReader sdr = command.ExecuteReader();
                    if (sdr.Read())
                    {
                        int id = sdr.GetInt32(0);
                        string name = sdr.GetString(1);
                        DateTime dateofbirth = sdr.GetDateTime(2);
                        return new Student { studentID = id, studentName = name, studentDOB = dateofbirth };
                    }
                    return null;
                }
            }
        }
        public static Course RetreivingCourse(int CourseID)
        {
            using (SqlConnection connection = GetConnection())
            {
                connection.Open();
                string query = "select * from courses where CourseID=@CourseID";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CourseID", CourseID);
                    SqlDataReader sdr = command.ExecuteReader();
                    if (sdr.Read())
                    {
                        int courseId = sdr.GetInt32(0);
                        string courseName = sdr.GetString(1);
                        return new Course { CourseID = courseId, CourseName = courseName };
                    }
                }
                return null;
            }
        }



       

       


    }
}
