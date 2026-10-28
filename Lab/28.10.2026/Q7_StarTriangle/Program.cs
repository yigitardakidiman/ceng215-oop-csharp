// Full Name: Yiğit Arda Kıdıman
// Student ID: 240208425
// Question: Q7 - Star Triangle

using System;

namespace Q7_StarTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read the number of rows as an integer.
            Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            // 2. If rows <= 0, display an error message.
            if (rows <= 0)
            {
                Console.WriteLine("Error: Please enter a positive integer.");
            }
            else
            {
                // 3. Otherwise, use an outer loop from row = 1 to rows.
                for (int row = 1; row <= rows; row++)
                {
                    // 4. Use an inner loop to print stars from 1 to the current row number.
                    for (int col = 1; col <= row; col++)
                    {
                        Console.Write("*");
                    }

                    // 5. Move to the next line after each row.
                    Console.WriteLine();
                }
            }
        }
    }
}
