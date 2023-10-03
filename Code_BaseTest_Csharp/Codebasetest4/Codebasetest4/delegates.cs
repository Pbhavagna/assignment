using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebasetest4
{
        delegate int CalculatorOperation(int num1, int num2);
        class Program
        {
            static int Add(int num1, int num2)
            {
                return num1 + num2;
            }
            static int Subtract(int num1, int num2)
            {
                return num1 - num2;
            }
            static int Multiply(int num1, int num2)
            {
                return num1 * num2;
            }
            static void Main()
            {
                CalculatorOperation add = Add;
                CalculatorOperation subtract = Subtract;
                CalculatorOperation multiply = Multiply;
                while (true)
                {
                    Console.WriteLine("Calculator:");
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Exit");
                    Console.Write("Enter your choice (1/2/3/4): ");
                    if (int.TryParse(Console.ReadLine(), out int choice))
                    {
                        if (choice >= 1 && choice <= 3)
                        {
                            Console.Write("Enter the first number: ");
                            if (int.TryParse(Console.ReadLine(), out int num1))
                            {
                                Console.Write("Enter the second number: ");
                                if (int.TryParse(Console.ReadLine(), out int num2))
                                {
                                    int result = 0;
                                    switch (choice)
                                    {
                                        case 1:
                                            result = add(num1, num2);
                                            Console.WriteLine($"Result: {num1} + {num2} = {result}");
                                            break;
                                        case 2:
                                            result = subtract(num1, num2);
                                            Console.WriteLine($"Result: {num1} - {num2} = {result}");
                                            break;
                                        case 3:
                                            result = multiply(num1, num2);
                                            Console.WriteLine($"Result: {num1} * {num2} = {result}");
                                            break;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Invalid number.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid number.");
                            }
                        }
                        else if (choice == 4)
                        {
                            Console.WriteLine("Exiting");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid choice");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, enetr valid input");
                    }
                    Console.WriteLine();
                }
            }
        }
    
}

