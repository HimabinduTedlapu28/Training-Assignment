using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebased_4
{
    public class Employee
    {
        internal string City;
        internal string Title;
        internal object LastName;
        private int e1;
        private string e2;
        private string e3;
        private string e4;
        private string e5;
        private string e6;
        private string e7;

        public Employee(int e1, string e2, string e3, string e4, string e5, string e6, string e7)
        {
            this.e1 = e1;
            this.e2 = e2;
            this.e3 = e3;
            this.e4 = e4;
            this.e5 = e5;
            this.e6 = e6;
            this.e7 = e7;
        }
    }
    public class question3
    {
        static void Main()
        {

            List<Employee> empList = new List<Employee>
            {



            new Employee(1001, "Malcolm", "Daruwalla", "Manager", "16/11/1984", "8/6/2011", "Mumbai"),
            new Employee(1002, "Asdin", "Dhalla", "AsstManager", "20/08/1984", "7/7/2012", "Mumbai"),
            new Employee(1003, "Madhavi", "Oza", "Consultant", "14/11/1987", "12/4/2015", "Pune"),
            new Employee(1004, "Saba", "Shaikh", "SE", "3/6/1990", "2/2/2016", "Pune"),
            new Employee(1005, "Nazia", "Shaikh", "SE", "8/3/1991", "2/2/2016", "Mumbai"),
            new Employee(1006, "Amit", "Pathak", "Consultant", "7/11/1989", "8/8/2014", "Chennai"),
            new Employee(1007, "Vijay", "Natrajan", "Consultant", "2/12/1989", "1/6/2015", "Mumbai"),
            new Employee(1008, "Rahul", "Dubey", "Associate", "11/11/1993", "6/11/2014", "Chennai"),
            new Employee(1009, "Suresh", "Mistry", "Associate", "12/8/1992", "3/12/2014", "Chennai"),
            new Employee(1010, "Sumit", "Shah", "Manager", "12/4/1991", "2/1/2016", "Pune")
            };
        
            var queryA = empList;
            Console.WriteLine("a. Details of all employees:");
            DisplayEmployees(queryA);

            
            var queryB = empList.Where(emp => emp.City != "Mumbai");
            Console.WriteLine("\nb. Details of employees whose location is not Mumbai:");
            DisplayEmployees((List<Employee>)queryB);

           
            var queryC = empList.Where(emp => emp.Title == "AsstManager");
            Console.WriteLine("\nc. Details of employees with title AsstManager:");
            DisplayEmployees((List<Employee>)queryC);

            
            var queryD = empList.Where(emp => emp.LastName.startswith("S"));
            Console.WriteLine("\nd. Details of employees whose Last Name starts with S:");
            DisplayEmployees(queryD);
        }
        static void DisplayEmployees(IEnumerable<Employee> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
            }
        }

        
    }


    
    
}
