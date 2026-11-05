// Full Name: Yiğit Arda Kıdıman
// Student ID: 240208425
// Question: Q1 - Exam Score Summary

using System;

namespace Q1_ExamScoreSummary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Set total, passed, and failed to 0.
            int total = 0;
            int passed = 0;
            int failed = 0;

            // 2. Read an integer score. Repeat while the score is different from -1.
            Console.Write("Enter a score: ");
            int score = Convert.ToInt32(Console.ReadLine());

            while (score != -1)
            {
                // 3. If the score is outside 0–100, display Invalid score.
                if (score < 0 || score > 100)
                {
                    Console.WriteLine("Invalid score.");
                }
                // 4. Otherwise, add it to total and increment passed if it is at least 60, or failed if it is below 60.
                else
                {
                    total += score;

                    if (score >= 60)
                    {
                        passed++;
                    }
                    else
                    {
                        failed++;
                    }
                }

                // 5. Read the next score at the end of each iteration.
                Console.Write("Enter a score: ");
                score = Convert.ToInt32(Console.ReadLine());
            }

            // 6. After the loop, calculate count = passed + failed.
            int count = passed + failed;

            // 7. If count is 0, display No valid scores entered.
            if (count == 0)
            {
                Console.WriteLine("No valid scores entered.");
            }
            // 8. Otherwise, display both counts and the average, (double)total / count.
            else
            {
                double average = (double)total / count;

                Console.WriteLine("Passed: " + passed);
                Console.WriteLine("Failed: " + failed);
                Console.WriteLine($"Average: {average:F2}");
            }
        }
    }
}
