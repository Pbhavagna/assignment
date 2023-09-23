using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    public class concession
    {
        public const int TotalFare = 500;
        public void CalculateConcession(string Name, int age)
        {
            if (age <= 5)
            {
                Console.WriteLine("Little Champs -Free Ticket");
                Console.WriteLine($"Name: {Name}  Age:{age}");


            }
            else if (age > 60)
            {
                double ConcessionAmount = 0.3 * TotalFare;
                double deductedAmount = TotalFare - ConcessionAmount;
                Console.WriteLine($"Name: {Name}  Age:{age}");
                Console.WriteLine($"Senior Citizen ,Fare: {deductedAmount}");
            }
            else
            {
                Console.WriteLine($"Ticket Booked ,Fare:{TotalFare}");
                Console.WriteLine($"Name: {Name}  Age:{age}");


            }
            Console.ReadLine();
        }

    }
}