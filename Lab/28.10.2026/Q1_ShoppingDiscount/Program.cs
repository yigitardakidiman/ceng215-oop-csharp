// Full Name: Yiğit Arda Kıdıman
// Student ID: 240208425
// Question: Q1 - Shopping Discount

using System;

namespace Q1_ShoppingDiscount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read the purchase amount as a double.
            Console.Write("Enter purchase amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            // 2. If the amount is at least 1000, calculate discount = amount * 0.10.
            // 3. Otherwise, set the discount to zero.
            double discount;
            if (amount >= 1000)
            {
                discount = amount * 0.10;
            }
            else
            {
                discount = 0;
            }

            // 4. Calculate finalPayment = amount - discount.
            double finalPayment = amount - discount;

            // 5. Display the discount and final payment.
            Console.WriteLine($"Discount: {discount:F2} TL");
            Console.WriteLine($"Final payment: {finalPayment:F2} TL");
        }
    }
}
