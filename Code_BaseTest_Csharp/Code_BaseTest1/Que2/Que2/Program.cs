using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Codetest1
{
    class test

    {
        public static void Main()
        {
            Console.WriteLine("Enter the Number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Multiplication table for {num} is");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($" {num} * {i} ={num * i}");

            }
            Console.ReadLine();
        }
    }
}

