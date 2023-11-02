using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___05
{
    class customer
    {
        static void Main()
        {

        }
        
        public int customerid;
        public int age;
        public string name;
        public int phone;
        public string city;
        public customer()
        {
            customer id = 0;
            age = 0;
            name = "";
            phone = 0;
            city = "";



        }
        public customer(int customerid, int age, string name, int phone, string city)
        {
            this.customerid = customerid;
            this.age = age;
            this.name = name;
            this.phone = phone;
            this.city = city;
        }
        public static void displaydata()
        {
            Console.WriteLine("customer id : ", +35);
            Console.WriteLine("age : " , +24);
            Console.WriteLine("name : " + "johnson");
            Console.WriteLine("phone : ", +907865432 );
            Console.WriteLine("city : " + "chennai");
        }
        ~customer()
        {
            Console.WriteLine("the details are : ");

            Console.ReadLine();
        }



        
    }
}
