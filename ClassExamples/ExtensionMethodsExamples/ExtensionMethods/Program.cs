using System;

namespace ExtensionMethods
{
    //// adding the extension method for class Calculator
    //public static class CalculatorExtensions
    //{
    //    public static double MPY(this Calculator cal, double number1, double number2) // you can choose any name, for class, but it should static and public
    //    {
    //        return number1 * number2;
    //    }

    //    public static string Greetings(this Calculator cal)
    //    {
    //        return "Welcome to Extension Methods";
    //    }
    //}

    class Program
    {


        static void Main(string[] args)
        {
            //testing the class
            Calculator cal = new Calculator();

            Console.WriteLine($"Sum: {cal.ADD(7.5,5.5):F2}");
            Console.WriteLine($"Diff: {cal.SUB(7.5, 5.5):F2}");

            Console.WriteLine($"Multi: {cal.MPY(7.5, 5.5):F2}");

            Console.WriteLine($"{ cal.Greetings()}");

            Console.WriteLine($"{ cal.ADD(7.5, 5.5, 2.3)}");

            cal.DisplayNumbers("a", "b","c");

        }
    }
}
