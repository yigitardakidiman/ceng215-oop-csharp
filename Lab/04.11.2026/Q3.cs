// Full Name: Yiğit Arda Kıdıman
// Student ID: 240208425
// Question: Q3 - Sort Three Numbers

using System;

namespace Q3_SortThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read three integers into first, second, and third.
            Console.Write("Enter the first number: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int third = Convert.ToInt32(Console.ReadLine());

            int temp;

            // 2. If first is greater than second, swap them.
            if (first > second)
            {
                temp = first;
                first = second;
                second = temp;
            }

            // 3. If second is greater than third, swap them. The largest value is now in third.
            if (second > third)
            {
                temp = second;
                second = third;
                third = temp;
            }

            // 4. Compare first and second again and swap them if needed.
            if (first > second)
            {
                temp = first;
                first = second;
                second = temp;
            }

            // 5. Display the three numbers in ascending order.
            Console.WriteLine($"Sorted numbers: {first} {second} {third}");
        }
    }
}
