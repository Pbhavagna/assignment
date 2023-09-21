using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Program
    {
        public static void Display(string Firstname, string Secondname)
        {
            Console.WriteLine(Firstname.ToUpper());
            Console.WriteLine(Secondname.ToUpper());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first name");
            string Firstname = Console.ReadLine();
            Console.WriteLine("Enter the Secondname");
            string Secondname = Console.ReadLine();
            Display(Firstname, Secondname);
            Console.ReadLine();
        }
    }
}