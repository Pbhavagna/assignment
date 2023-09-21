using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    class count
    {
        public static void Main()
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the letter that must be counted");
            char letter = Convert.ToChar(Console.ReadLine());
            int Countletter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == letter)
                {
                    Countletter++;
                }

            }
            Console.WriteLine($"The no of times {letter} is repeated in the given string is {Countletter}");
            Console.ReadLine();

        }
    }
}

    

