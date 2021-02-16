using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200424
{
    static class ReverseString
    {
        /* 8. Reverse a String(solution)
         * This problem is similar to the String Palindrome problem we have discussed above.
         * If you can solve that problem, you can solve this as well.
         * You can use indexOf() or substring() to reverse a String or alternatively, 
         * convert the problem to reverse an array by operating on character array instead of String.
         * If you want to brush up your data structure skill you can also check Data Structures
         * and Algorithms: Deep Dive Using Java course on Udemy before solving this question.
         * Read more: https://javarevisited.blogspot.com/2017/07/top-50-java-programs-from-coding-Interviews.html#ixzz6KXPdjPha
         */
        public static void Run()
        {
            Console.Out.Write("Enter string:");
            string userInput = Console.In.ReadLine();

            Console.WriteLine("Reversed: " + ReverseRecursively(userInput));

        }

        private static string Reverse(string text)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }

            return sb.ToString();
        }

        private static string ReverseRecursively(string text)
        {
            return String.IsNullOrEmpty(text) ? "" : 
                text.Last() + ReverseRecursively(text.Substring(0, text.Length - 1));
        }

    }
}
