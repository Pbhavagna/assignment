using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebasetest3
{
    using System;


    class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }

        public Box(double length, double breadth)
        {
            Length = length;
            Breadth = breadth;
        }

        public static Box Add(Box box1, Box box2)
        {
            double combinedLength = box1.Length + box2.Length;
            double combinedBreadth = box1.Breadth + box2.Breadth;
            return new Box(combinedLength, combinedBreadth);
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Length: {Length}");
            Console.WriteLine($"Breadth: {Breadth}");
        }
    }

    class Test
    {
        static void Main(string[] args)
        {
            Box box1 = new Box(50, 30);
            Box box2 = new Box(20, 40);

            Box box3 = Box.Add(box1, box2);

            Console.WriteLine("Box 1:");
            box1.DisplayDetails();

            Console.WriteLine("\nBox 2:");
            box2.DisplayDetails();

            Console.WriteLine("\nBox 3:");
            box3.DisplayDetails();

            Console.ReadKey();
        }
    }
}
