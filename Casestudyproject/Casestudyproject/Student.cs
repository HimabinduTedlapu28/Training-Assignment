using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casestudyproject
{
    public class Student
    {
        

        public int Id { get; set; }
        public string Name { get; set; }
        public string Dateofbirth { get; set; }
        public Student(int Id, string Name, string Dateofbirth)
        {
            this.Id = Id;
            this.Name = Name;
            this.Dateofbirth = Dateofbirth;
        }

        
    }
}



