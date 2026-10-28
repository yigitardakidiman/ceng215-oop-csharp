// Full Name: Yiğit Arda Kıdıman
// Student ID: 240208425
// Question: Q5 - Sum Until Zero

using System;

namespace Q5_SumUntilZero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Initialize sum and count to zero.
            int sum = 0;
            int count = 0;

            // 2. Read the first integer before entering the loop.
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // 3. While the number is not zero, add it to sum and increment count.
            while (number != 0)
            {
                sum += number;
                count++;

                // 4. Read the next integer inside the loop.
                Console.Write("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());
            }

            // 5. When zero is entered, display sum and count.
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Count: " + count);
        }
    }
}
