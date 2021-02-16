using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200422
{
    /*
     * 3. String Palindrome (solution)
     * You need to write a simple Java program to check if a given String is palindrome or not. 
     * A Palindrome is a String which is equal to the reverse of itself, e.g., 
     * "Bob" is a palindrome because of the reverse of "Bob" is also "Bob."  
     * Though be prepared with both recursive and iterative solution of this problem. 
     * The interviewer may ask you to solve without using any library method, e.g. indexOf() or subString() so be prepared for that.
     * Read more: https://javarevisited.blogspot.com/2017/07/top-50-java-programs-from-coding-Interviews.html#ixzz6KLgJhjvU
     * 
     */
    public static class Palindrome
    {
        public static void Run()
        {
            Console.Out.Write("Enter string:");
            string userInput = Console.In.ReadLine();

            //if (IsPalindrome(userInput.ToLower()))
            //{
            //    Console.WriteLine(userInput + " is a palindrome");
            //}
            //else
            //{
            //    Console.WriteLine(userInput + " is NOT a palindrome");
            //}
            if (IsPalindromeWithReverse(userInput.ToLower()))
            {
                Console.WriteLine(userInput + " is a palindrome");
            }
            else
            {
                Console.WriteLine(userInput + " is NOT a palindrome");
            }

        }

        private static bool IsPalindrome(string str)
        {
            // base cases
            int len = str.Length;

            if (len == 0)
            {
                return true;
            }
            else if (len == 1)
            {
                return true;
            }
            else
            {
                //check if the head matches the tail
                return (str.StartsWith(str.Substring(len - 1))
                                        ? IsPalindrome(str.Substring(1, len - 2)) : false);
            }
        }

        // alternative solution
        private static bool IsPalindromeWithReverse(string text)
        {
            return text.Equals(Reverse(text)) ? true : false;
        }

        private static string Reverse(string input)
        {            
            return String.IsNullOrEmpty(input) ? input
                : input.Last() + Reverse(input.Substring(0, input.Length - 1));
        }

    }







}


