// Full Name: Yiğit Arda Kıdıman
// Student ID: 240208425
// Question: Q2 - Temperature Classification

using System;

namespace Q2_TemperatureClassification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Read the temperature as a double.
            Console.Write("Enter temperature: ");
            double temperature = Convert.ToDouble(Console.ReadLine());

            // 2. If temperature < 0, display Freezing.
            if (temperature < 0)
            {
                Console.WriteLine("Freezing");
            }
            // 3. Otherwise, if temperature < 15, display Cold.
            else if (temperature < 15)
            {
                Console.WriteLine("Cold");
            }
            // 4. Otherwise, if temperature < 25, display Mild.
            else if (temperature < 25)
            {
                Console.WriteLine("Mild");
            }
            // 5. Otherwise, display Hot.
            else
            {
                Console.WriteLine("Hot");
            }
        }
    }
}
