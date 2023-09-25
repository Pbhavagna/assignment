using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebasetest3 
{
    using System;

    class Cricket
    {
        public void Pointscalculation(int[] no_of_matches)
        {
            int sum = 0;

            foreach (int score in no_of_matches)
            {
                sum += score;
            }

            double average = (double)sum / no_of_matches.Length;

            Console.WriteLine($"Sum of scores: {sum}");
            Console.WriteLine($"Average score: {average}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of matches: ");
            if (int.TryParse(Console.ReadLine(), out int no_of_matches) && no_of_matches > 0)
            {
                int[] scores = new int[no_of_matches];

                for (int i = 0; i < no_of_matches; i++)
                {
                    Console.Write($"Enter score for match {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int score))
                    {
                        scores[i] = score;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input,enter a valid score.");
                        i--; 
                    }
                }

                Cricket cricket = new Cricket();
                cricket.Pointscalculation(scores);
            }
            else
            {
                Console.WriteLine("Invalid input, enter a valid number of matches.");
            }
            Console.ReadKey();
        }
    }
}
