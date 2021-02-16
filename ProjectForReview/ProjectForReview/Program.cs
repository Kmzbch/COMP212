using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectForReview
{
    public class Calculator
    {
        public double ADD(double num1, double num2) => num1 + num2;
    }

    public static class CalculatorExtensions
    {
        public static double MPY(this Calculator cal, double num1, double num2) => num2 * num2;
    }

    // declares an extension method 
    static class Extensions
    {
        public static void Display<T>(this IEnumerable<T> data) => Console.WriteLine(string.Join(" ", data));
    }

    class Program
    {
        static void Main(string[] args)
        {
            // extention methods
            Calculator calc = new Calculator();
            Console.WriteLine(calc.ADD(1, 1));
            Console.WriteLine(calc.MPY(3, 4));

            // 
            FunctionalProgramingDemo();
        }

        static void FunctionalProgramingDemo()
        {
            var values = new List<int> { 3, 10, 6, 1, 4, 8, 2, 5, 9, 7 };

            Console.Write("Original values: ");
            values.Display(); // call Display extension method

            // display the Min, Max, Sum and Average
            Console.WriteLine($"\nMin: {values.Min()}");
            Console.WriteLine($"Max: {values.Max()}");
            Console.WriteLine($"Sum: {values.Sum()}");
            Console.WriteLine($"Average: {values.Average()}");

            // sum of values via Aggregate
            Console.WriteLine("\nSum via Aggregate method: " + values.Aggregate(0, (x, y) => x + y));

            // sum of squares of values via Aggregate
            Console.WriteLine("Sum of squares via Aggregate method: " + values.Aggregate(0, (x, y) => x + y * y));

            // product of values via Aggregate
            Console.WriteLine("Product via Aggregate method: " + values.Aggregate(1, (x, y) => x * y));

            // even values displayed in sorted order
            Console.Write("\nEven values displayed in sorted order: ");
            values.Where(value => value % 2 == 0) // find even integers
                  .OrderBy(value => value) // sort remaining values
                  .Display(); // show results

            // odd values multiplied by 10 and displayed in sorted order
            Console.Write("Odd values multiplied by 10 displayed in sorted order: ");
            values.Where(value => value % 2 != 0) // find odd integers
                  .Select(value => value * 10) // multiply each by 10
                  .OrderBy(value => value) // sort the values
                  .Display(); // show results

            // display original values again to prove they were not modified
            Console.Write("\nOriginal values: ");
            values.Display(); // call Display extension method
        }
    }


}
