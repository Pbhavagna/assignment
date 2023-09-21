using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter the row size of 2d array ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter the colomn size\n");
            int c = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[r, c];
            Console.WriteLine("enter the input values for  ");
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    Console.WriteLine($" { arr[i, j] } ");
            Console.Read();
        }
    }
}
