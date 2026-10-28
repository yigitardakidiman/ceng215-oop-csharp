// Full Name: Yiğit Arda Kıdıman
// Student ID: 240208425
// Question: Q3 - Temperature Converter

using System;

namespace Q3_TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the temperature in Celsius and convert the input to double.
            Console.Write("Enter the temperature in Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            // F = C x 9.0 / 5 + 32
            double fahrenheit = celsius * 9.0 / 5 + 32;

            // Display the result.
            Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
        }
    }
}
