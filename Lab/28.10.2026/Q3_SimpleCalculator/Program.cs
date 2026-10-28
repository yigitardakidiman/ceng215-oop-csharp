// Full Name: Yiğit Arda Kıdıman
// Student ID: 240208425
// Question: Q3 - Simple Calculator

using System;

namespace Q3_SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read two numbers as doubles and the operator as a string.
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator: ");
            string? op = Console.ReadLine();

            // 2. Use switch to select the matching operator.
            switch (op)
            {
                case "+":
                    // 3. For +, - and *, calculate and display the result.
                    Console.WriteLine("Result: " + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine("Result: " + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine("Result: " + (num1 * num2));
                    break;
                case "/":
                    // 4. For /, check the second number before dividing.
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                    }
                    else
                    {
                        Console.WriteLine("Result: " + (num1 / num2));
                    }
                    break;
                default:
                    // 5. Use default to display an invalid operator message.
                    Console.WriteLine("Error: Invalid operator.");
                    break;
            }
        }
    }
}
