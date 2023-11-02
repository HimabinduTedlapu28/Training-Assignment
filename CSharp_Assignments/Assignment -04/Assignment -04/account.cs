using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment__04
{
    class account
    {
        public int Accountnumber;
        public string name;
        public string accounttype;
        public string transactiontype;
        public int amount;
        public int balance;
        public account(int Accountno, string customername, string accounttype, string transactiontype, int amount, int balance)
        {
            this.Accountnumber = Accountnumber;
            this.name = customername;
            this.accounttype = accounttype;
            this.transactiontype = "";
            this.amount = 0;
            this.balance = 0;

        }
        public void credit(int depositamount)
        {
            if (amount <=  0)
            {
                Console.WriteLine("no deposit amount");
            }
            else
            {
                balance += depositamount;
                transactiontype = "deposit";
                amount = depositamount;
            }
        }
        public void Debit(int withdrawlamount)
        {
            if (withdrawlamount <= 0)
            {
                Console.WriteLine("no withdrawl amount");
            }
            else if ( balance < withdrawlamount)
            {
                Console.WriteLine("no balance");
            }
            else
            {
                balance -= withdrawlamount;
                transactiontype = "withdrawl";
                amount = withdrawlamount;
            }
        }


        public void displaydata()
        {
            Console.WriteLine("Account number : " + Accountnumber);
            Console.WriteLine("Accounttype: " + accounttype);
            Console.WriteLine("name :" + name);
            Console.WriteLine("transactiontype: " +  Transactiontype);
            Console.WriteLine("amount : " + amount);
            Console.WriteLine("balance : " + balance);

        }
    
        static void Main()
        {
            account a = new account( 12345, "john", "savings", "deposit", 1000, 20344 );
                a.credit(1000);
                a.displaydata();

                a.Debit( 50);
                a.displaydata();
            Console.ReadLine();

        }

        
        
        
            

        



    }
}
