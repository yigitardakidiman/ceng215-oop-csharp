// Full Name: Yiğit Arda Kıdıman
// Student ID: 240208425
// Question: Q2 - Pattern Design

using System;

namespace Q2_PatternDesign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read N as an integer.
            Console.Write("Enter the size: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // 2. If N <= 0, display Invalid size. and stop.
            if (n <= 0)
            {
                Console.WriteLine("Invalid size.");
            }
            else
            {
                // 3. Use nested for loops to visit each row and column, starting both at 0.
                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        // 4. Print <> if (row + column) is even. Otherwise, print {}.
                        if ((row + col) % 2 == 0)
                        {
                            Console.Write("<>");
                        }
                        else
                        {
                            Console.Write("{}");
                        }
                    }

                    // 5. Move to the next line after each row.
                    Console.WriteLine();
                }
            }
        }
    }
}
