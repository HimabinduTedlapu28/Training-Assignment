using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__04
{
    class student
    {

        public int rollno;
        public string name;
        public int Class;
        public int semester;
        public string branch;
        public int[] marks = new int[5];
        public student(int rollno, string name, int Class, int sem, string branch)
        {
            this.rollno = rollno;
            this.name = name;
            this.Class = Class;
            this.semester = sem;
            this.branch = branch;
        }

        public void GetMarks()
        {
            Console.WriteLine(" enter the marks of 5 subjects : ");
            for (int i = 0; i < 5; i++)

            {
                Console.WriteLine("subject" + (i + 1) + ":");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public void Displayresult()
        {
            int sum = 0;
            foreach (int mark in marks)
            {
                sum += mark;
            }
            float average = (float)sum / 5;
            Console.WriteLine("Average marks :" + average);
            bool failed = false;
            foreach (int mark in marks)
            {
                if (mark < 35)
                {
                    failed = true;
                    break;


                }
                if (average < 50)
                {
                    Console.WriteLine(" result : failed");
                }
                else
                {
                    Console.WriteLine("result : passed");
                }
            }
        }
        public void Displaydata()
        {
            Console.WriteLine("student details : ");
            Console.WriteLine("rollno : " + rollno);
            Console.WriteLine("name : " + name);
            Console.WriteLine("Class : " + Class);
            Console.WriteLine("Semester : " + semester);
            Console.WriteLine("branch : " + branch);
        }
        static void Main()
        {
            student a = new student(34, " john", 4, 3, "ece");
            a.GetMarks();
            a.Displayresult();
            a.Displaydata();
            Console.ReadLine();





        }
    }
}
