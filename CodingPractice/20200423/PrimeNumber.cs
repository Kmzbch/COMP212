using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 2. A prime number (solution)
 * Write a Java program to check if a given number is prime or not. 
 * Remember, a prime number is a number which is not divisible by any other number, 
 * e.g. 3, 5, 7, 11, 13, 17, etc. Be prepared for cross, 
 * e.g. checking till the square root of a number, etc.
 * 
 * Read more: https://javarevisited.blogspot.com/2017/07/top-50-java-programs-from-coding-Interviews.html#ixzz6KRYPaQ39
 */

namespace _20200423
{
    public static class PrimeNumber
    {
        public static void Run()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.In.ReadLine());

            if (IsPrimeNumber(number))
            {
                Console.WriteLine(number + " is a prime number");
            }
            else
            {
                Console.WriteLine(number + " is NOT a prime number");
            }

            for (int i = 1; i < number; i++)
            {
                if (IsPrimeNumber(i))
                {
                    Console.Write(i + " ");
                }
            }

        }

        private static bool IsPrimeNumber(int num)
        {
            if (num == 1)
            {
                return false;
            }
            if (num == 2 || num == 3)
            {
                return true;
            }
                if (num % 2 == 0)
            {
                return false;
            }

            int sqrt = (int)Math.Sqrt(num) + 1;
            for(int i = 2; i < sqrt; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }


    }
}
