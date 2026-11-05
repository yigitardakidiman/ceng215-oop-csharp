// Full Name: Yiğit Arda Kıdıman
// Student ID: 240208425
// Question: Q4 - Hollow Rectangle

using System;

namespace Q4_HollowRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read the number of rows and columns as integers.
            Console.Write("Enter the number of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the number of columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());

            // 2. If either value is zero or negative, display Invalid dimensions. and skip drawing.
            if (rows <= 0 || cols <= 0)
            {
                Console.WriteLine("Invalid dimensions.");
            }
            else
            {
                // 3. Use an outer for loop for the rows and an inner for loop for the columns.
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        // 4. Print * if the cell is in the first or last row or in the first or last column. Otherwise, print a space.
                        if (r == 0 || r == rows - 1 || c == 0 || c == cols - 1)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    // 5. Move to the next line after printing each row.
                    Console.WriteLine();
                }
            }
        }
    }
}
