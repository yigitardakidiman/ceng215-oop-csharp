// Full Name: Yiğit Arda Kıdıman
// Student ID: 240208425
// Question: Q3 - Match Students with Courses

using System;

namespace Q3_MatchStudentsCourses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read the number of students.
            Console.Write("How many students? ");
            int studentCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // 2. Store student names and course names in two separate string[] arrays.
            string[] studentNames = new string[studentCount];
            string[] courseNames = new string[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"Enter student {i + 1} name: ");
                studentNames[i] = Console.ReadLine() ?? "";

                Console.Write($"Enter {studentNames[i]}'s course: ");
                courseNames[i] = Console.ReadLine() ?? "";

                Console.WriteLine();
            }

            // 3. Copy each pair into one row of a string[,] array.
            string[,] pairs = new string[studentCount, 2];
            for (int i = 0; i < studentCount; i++)
            {
                pairs[i, 0] = studentNames[i];
                pairs[i, 1] = courseNames[i];
            }

            // 4. Print each pair from the two-dimensional array.
            Console.WriteLine("Student-Course Pairs");
            for (int i = 0; i < pairs.GetLength(0); i++)
            {
                Console.WriteLine($"{pairs[i, 0]} - {pairs[i, 1]}");
            }
        }
    }
}
