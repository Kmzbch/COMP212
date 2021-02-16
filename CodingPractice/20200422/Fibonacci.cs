using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200422
{
    /*
     * 1. Fibonacci series (solution)
     * Write a simple Java program which will print Fibonacci series, 
     * e.g. 1 1 2 3 5 8 13 ... . up to a given number. We prepare for cross questions like 
     * using iteration over recursion and how to optimize the solution using caching and memoization.
     * 
     * Read more: https://javarevisited.blogspot.com/2017/07/top-50-java-programs-from-coding-Interviews.html#ixzz6KLbtWPoi
     */
    public static class Fibonacci
    {
        public static void Run()
        {
            // prompt user to enter the first number of the series to print out
            Console.Write("Enter the last term of fibonacci series: ");
            int userInput = Convert.ToInt32(Console.In.ReadLine());

//            Console.WriteLine(Fib(userInput));

            for(int i = 1; i <= userInput; i++)
            {
                string space = i == userInput ? "" : " ";
                Console.Write(Fib(i) + space);
            }

            Console.WriteLine();
        }

        private static int Fib(int n)
        {
            return n <= 1 ? n :
                Fib(n - 1) + Fib(n - 2);
        }

    }
}
