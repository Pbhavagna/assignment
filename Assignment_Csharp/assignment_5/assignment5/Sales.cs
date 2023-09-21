using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment5
{
    class Sales
    {
        double Salesno, Productno, Price, Total_Amount = 0;
        
        int qty;
        Sales(double salesno, double productno, double price)
        {
            this.Salesno = salesno;
            this.Productno = productno;
            this.Price = price;

        }
        static public void sales(int qty, Sales ob)
        {
            Console.WriteLine($"Total amount  {ob.Total_Amount = qty * ob.Price}");
        }
        public static void Main(String[] args)
        {
            Sales ob1 = new Sales(1, 1, 100);
            Sales ob2 = new Sales(2, 2, 250);
            Sales ob3 = new Sales(3, 3, 250);
            Sales ob4 = new Sales(4, 4, 500);
            Sales ob5 = new Sales(5, 5, 600);
            Console.WriteLine(" Enter the product no");
            Console.WriteLine("1.Dress, 2.cosmetics, 3.Footware ,4.Accessories 5.skincare");
            char c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"DRESS PRICE {ob1.Price}");
            Console.WriteLine($"COSMETICS PRICE {ob2.Price}");
            Console.WriteLine($"FOOTWARE PRICE {ob3.Price}");
            Console.WriteLine($"ACCESSORIES PRICE  {ob4.Price}");
            Console.WriteLine($"SKINCARE_PRICE {ob5.Price}");
            Console.WriteLine("enter the quantity");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case '1':
                    sales(n, ob1);
                    break;
                case '2':
                    sales(n, ob2);
                    break;
                case '3':
                    sales(n, ob3);
                    break;
                case '4':
                    sales(n, ob4);
                    break;
                case '5':
                    sales(n, ob5);
                    break;
                default:
                    Console.WriteLine("Enter correct option");
                    break;
            }
            Console.Read();

        }

    }
}
    

