using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casestudyproject
{
    public class Enroll
    {
        public Student student { get; set; }
        public Course course { get; set; }
        public DateTime Enrollmentdate { get; set; }
        public Enroll(Student student , Course course, DateTime Enrollmentdate)
        {
            this.student = student;
            this.course = course;
            this.Enrollmentdate = Enrollmentdate;
        }
    }
}
