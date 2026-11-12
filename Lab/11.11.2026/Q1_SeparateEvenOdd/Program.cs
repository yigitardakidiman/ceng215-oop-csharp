// Full Name: Yiğit Arda Kıdıman
// Student ID: 240208425
// Question: Q1 - Separate Even and Odd Numbers

using System;

namespace Q1_SeparateEvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read N as an integer. If it is negative, display an error and stop.
            Console.Write("Enter N: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Error: N must be a non-negative integer.");
                return;
            }

            // 2. Create an even array of size N / 2 + 1 and an odd array of size N / 2 + N % 2.
            int[] evenNumbers = new int[n / 2 + 1];
            int[] oddNumbers = new int[n / 2 + (n % 2)];

            // 3. Set the next available index in each array to 0.
            int evenIndex = 0;
            int oddIndex = 0;

            // 4. Loop from 0 to N, inclusive. Use % 2 to choose the correct array, store the number, and advance that array’s index.
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    evenNumbers[evenIndex] = i;
                    evenIndex++;
                }
                else
                {
                    oddNumbers[oddIndex] = i;
                    oddIndex++;
                }
            }

            // 5. Display the two arrays separately using foreach.
            Console.Write("Even numbers: ");
            foreach (int num in evenNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.Write("Odd numbers: ");
            foreach (int num in oddNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
