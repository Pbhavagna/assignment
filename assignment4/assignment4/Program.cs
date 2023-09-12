using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    class Accounts
    {
        static void Main(string[] args)
        {
            /*int AccNo = 123;
            string CustomerName = "Bhavagna";
            string AccType = "ABCbank";
            string[] TrancType = { "Withdrawal", "Deposit" };
            double Amt = 50000;
            //double balance;*/
            Accounts.TrancType();
            
        }
        public static void TrancType()
        {
            Console.WriteLine("Choose Transaction Type: ");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdrawal");

            Console.WriteLine("Enter your transaction type 1 or 2: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Accounts.credit();
            }
            else if (choice==2)
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }

            Console.ReadKey();
        }
        public static void credit()
        {
            Console.WriteLine("Enter the amount to be deposited: ");
            double DepositAmt = Convert.ToDouble(Console.ReadLine());
            double balance;
            if (DepositAmt<=0)
            {
                Console.WriteLine("Entered amount is inappropriate");
            }
            else
            {
                 balance += DepositAmt;

            }
        }
    }
}
