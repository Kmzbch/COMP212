using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    // adding the extension method for class Calculator
    public static class CalculatorExtensions
    {
        public static double MPY(this Calculator cal, double number1, double number2) // you can choose any name, for class, but it should static and public
        {
            return number1 * number2;
        }

        public static string Greetings(this Calculator cal)
        {
            return "Welcome to Extension Methods";
        }


        public static double ADD(this Calculator cal, double number1, double number2, double number3)
        {
            return number1 + number2 + number3;
        }

        public static void DisplayNumbers<T>(this Calculator cal, T item1, T item2, T item3)
        {
            Console.WriteLine($"{item1} {item2} {item3}");
        }

    }
}
