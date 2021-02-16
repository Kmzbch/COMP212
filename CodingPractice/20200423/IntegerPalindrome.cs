
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200423
{
    /*
     * 4. Integer Palindrome (solution)
     * This is generally asked as follow-up or alternative of the previous program. 
     * This time you need to check if given Integer is palindrome or not. 
     * An integer is called palindrome if it's equal to its reverse, 
     * e.g. 1001 is a palindrome, but 1234 is not because the reverse of 1234 is 4321 
     * which is not equal to 1234. 
     * You can use divide by 10 to reduce the number and modulus 10 to get the last digit. 
     * This trick is used to solve this problem.
     * 
     * Read more: https://javarevisited.blogspot.com/2017/07/top-50-java-programs-from-coding-Interviews.html#ixzz6KRhfXMFy
     */
    public static class IntegerPalindrome
    {
        public static void Run()
        {
            Console.Out.Write("Enter Intger:");
            int number = int.Parse(Console.In.ReadLine());

            //if (IsIntegerPalindrome(number))
            //{
            //    Console.WriteLine(number + " is a palindrome");
            //}
            //else
            //{
            //    Console.WriteLine(number + " is NOT a palindrome");
            //}
            if (IsIntegerPalindromeWithReverse(number))
            {
                Console.WriteLine(number + " is a palindrome");
            }
            else
            {
                Console.WriteLine(number + " is NOT a palindrome");
            }


        }

        private static bool IsIntegerPalindrome(int number)
        {
            // base case
            if (number / 10 < 1)
            {
                return true;
            }
            else
            {
                int totalDigits = 0;
                int rightDigit = number % 10;

                int dividend = number;
                while (dividend / 10 >= 1)
                {
                    dividend = dividend / 10;
                    totalDigits++;
                }
                int leftDigit = dividend;

                int leftDigitsPlace = Convert.ToInt32((Math.Pow((10), totalDigits)));
                int middleDigits = (number - rightDigit - leftDigit * leftDigitsPlace) / 10;

                //check if the head matches the tail
                return leftDigit == rightDigit ? IsIntegerPalindrome(middleDigits) : false;
            }
        }

        // alternative solution(no recursion)
        private static bool IsIntegerPalindromeWithReverse(int number)
        {
            int palindrome = number;
            int reverse = 0;

            while (palindrome != 0)
            {
                int remainder = palindrome % 10;
                reverse = reverse * 10 + remainder;
                palindrome /= 10;
            }

            return number == reverse ? true : false;
        }

    }
}
