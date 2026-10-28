// Full Name: Yiğit Arda Kıdıman
// Student ID: 240208425
// Question: Q6 - Number Validation

using System;

namespace Q6_NumberValidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Declare an integer variable before the loop.
            int number;

            // 2. Inside do, read a number.
            do
            {
                Console.Write("Enter a number between 1 and 10: ");
                number = Convert.ToInt32(Console.ReadLine());

                // 3. If number < 1 or number > 10, display the error message.
                if (number < 1 || number > 10)
                {
                    Console.WriteLine("Invalid number. Try again.");
                }

            // 4. Repeat while the number is outside the valid range.
            } while (number < 1 || number > 10);

            // 5. After the loop, display Number accepted.
            Console.WriteLine("Number accepted.");
        }
    }
}
