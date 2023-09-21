using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assignment1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int fnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int snum = Convert.ToInt32(Console.ReadLine());
            if (fnum == snum)



                Console.WriteLine($"{fnum} and {snum} are equal");



            else



                Console.WriteLine($"{fnum} and {snum} are not equal");



            Program.PosOrNeg();
            Program.operations();



            Console.Read();





        }
        public static void PosOrNeg()
        {
            Console.WriteLine("enter the value");
            int i = Convert.ToInt32(Console.ReadLine());



            if (i >= 0)
            {
                Console.WriteLine($"{i} is a positive");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine($"{i} is a negative");



            }
            Console.ReadLine();
        }



        public static void operations()
        {
            Console.WriteLine("Enter the first number");
            int j = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int k = Convert.ToInt32(Console.ReadLine());
            int sum = j + k;
            Console.WriteLine("{0}", sum);
            int sub = j - k;
            Console.WriteLine("{0}", sub);
            int mul = j * k;
            Console.WriteLine("{0}", mul);
            int div = j / k;
            Console.WriteLine("{0}", div);
            Console.ReadLine();



        }

    }
}
