using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment___05
{
    class sales
    {
        static void Main()
        {

        }
        public int salesno;
        public int productno;
        public int price;
        public string date;
        public int quantity;
        public int totalamount;
        public sales(int salesno, int productno, int price, string date, int quantity)
        {
            this.salesno = salesno;
            this.productno = productno;
            this.price = price;
            this.date = date;
            this.quantity = quantity;
            this.totalamount = totalamount; 
        }
        public void Sales()
        {
            totalamount = quantity * price;
        }

        public void ShowData()
        {
            Console.WriteLine("Sales No: " + salesno);
            Console.WriteLine("Product No: " + productno);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Date of Sale: " + date);
            Console.WriteLine("Qty: " + quantity);
            Console.WriteLine("Total Amount: " + totalamount);
        }
    }

    class Program
    {
        static void Main()
        {
            sales sale = new sales(1, 101, 50, "15-09-2023" , 3);
            sale.ShowData();

            
            Console.ReadLine();
        }
    }
    








    

}
