using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{

        class stringprog

        {

            public static void strlen()

            {

                Console.WriteLine("Enter the string");

                string s = Console.ReadLine();

                int len = s.Length;

                Console.WriteLine("The string length is: {0} ", len);

            }

            public static void strreverse()

            {

                Console.WriteLine("Enter the string");

                string s = Console.ReadLine();

                char[] s1 = s.ToCharArray();

                Array.Reverse(s1);

                string reversedword = new string(s1);

                Console.WriteLine($"The reversed string is {reversedword}");



            }

            public static void strcompare()

            {

                Console.WriteLine("Enter the first string ");

                string s1 = Console.ReadLine();

                Console.WriteLine("Enter the second string ");

                string s2 = Console.ReadLine();

                if (string.Equals(s1, s2))

                {

                    Console.WriteLine("Both strings are same");

                }

                else

                {

                    Console.WriteLine("Both strings are not same");

                }

            }



        }



        class Program

        {

            public static void Main(string[] args)

            {

                stringprog.strlen();

                stringprog.strreverse();

                stringprog.strcompare();

                Console.Read();

            }

        }

    }

