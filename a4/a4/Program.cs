using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    class Accounts
    {
        public int AccNum;
        public string CustomerName;
        public string AccType;



        public Accounts(int accnum, string customerName, string acctype)
        {
            this.AccNum = accnum;
            this.CustomerName = customerName;
            this.AccType = acctype;



        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Account Number :{AccNum}");
            Console.WriteLine($"Your Name :{CustomerName}");
            Console.WriteLine($"Your Account Type:{AccType}");


        }
        public static void Main(string[] args)
        {
           
            Accounts info = new Accounts(123, "Bhavagna", "Savings");

            info.DisplayInfo();
            Console.WriteLine("Your present balance is 5000");
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
            else if (choice == 2)
            {
                Accounts.debit();
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
            double balance = 5000;
            if (DepositAmt <= 0 )
            {
                Console.WriteLine("Entered amount is invalid");
            }
            else
            {
                balance += DepositAmt;
                Console.WriteLine("Updated Balance");
                Console.WriteLine(balance);

            }
        }
        public static void debit()
        {
            Console.WriteLine("Enter the amount to be Withdraw: ");
            double WithdrawAmt = Convert.ToDouble(Console.ReadLine());
            double balance = 5000;
            if (WithdrawAmt == 0 || WithdrawAmt > balance)
            {
                Console.WriteLine("Entered amount is inappropriate");
                
            }
            else
            {
                balance -= WithdrawAmt;
                Console.WriteLine("Updated Balance");
                Console.WriteLine(balance);

            }
        }
      
    }
    
}
