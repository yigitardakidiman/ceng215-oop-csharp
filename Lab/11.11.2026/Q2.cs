// Full Name: Yiğit Arda Kıdıman
// Student ID: 240208425
// Question: Q2 - Daily Expense Tracker

using System;
using System.Collections.Generic;

namespace Q2_DailyExpenseTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a List<decimal>.
            List<decimal> expenses = new List<decimal>();

            // 2. Read expenses until 0. Add positive amounts and display an error for negative amounts.
            while (true)
            {
                Console.Write("Enter an expense (0 to finish): ");
                decimal amount = Convert.ToDecimal(Console.ReadLine());

                if (amount == 0)
                {
                    break;
                }
                else if (amount > 0)
                {
                    expenses.Add(amount);
                }
                else
                {
                    Console.WriteLine("Invalid expense.");
                }
            }

            // 3. Use foreach to sum the expenses and count those of 100 TL or more.
            decimal total = 0;
            int count100OrMore = 0;

            foreach (decimal exp in expenses)
            {
                total += exp;
                if (exp >= 100)
                {
                    count100OrMore++;
                }
            }

            // 4. Display Count, the total to two decimal places, and the count of expenses of 100 TL or more.
            Console.WriteLine();
            Console.WriteLine($"Expenses recorded: {expenses.Count}");
            Console.WriteLine($"Total expenses: {total:F2} TL");
            Console.WriteLine($"Expenses of 100 TL or more: {count100OrMore}");
        }
    }
}
