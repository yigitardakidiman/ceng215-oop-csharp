// Full Name: Yiğit Arda Kıdıman
// Student ID: 240208425
// Question: Q4 - Even Numbers and Their Sum

using System;

namespace Q4_EvenNumbersAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read N as an integer.
            Console.Write("Enter N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // 2. If N <= 0, display an error message.
            if (n <= 0)
            {
                Console.WriteLine("Error: Please enter a positive integer.");
            }
            else
            {
                // 3. Otherwise, initialize sum to zero.
                int sum = 0;

                Console.Write("Even numbers: ");

                // 4. Loop from 2 to N in increments of 2.
                for (int i = 2; i <= n; i += 2)
                {
                    // 5. Print each value and add it to sum.
                    Console.Write(i + " ");
                    sum += i;
                }

                Console.WriteLine();

                // 6. Display the sum after the loop.
                Console.WriteLine("Sum: " + sum);
            }
        }
    }
}
