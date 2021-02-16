/**
 * C061: Addition without Carrying Over

 * Input Value:
 * 
 * Input is given in the following format:
 * A B
 * Integers A & B for addition are entered separated by a single space.
 * The input is on a single line and contains a newline at the end.
 * Each value is passed from the standard input as a string.
 * 
 * Expected Output:
 * Print the result of addition without carrying over.
 * Match the number of digits to the larger one
 * Put a new line at the end. No extra characters or blank lines included.
 * 
 * Conditions:
 * All the testcases meet the following conditions:
 * 1 <= A, B <= 999
 * 
 * Examples:
 * Input:
 * 98 75
 * Output:
 * 63
*
 * Input:
 * 274 840
 * Output:
 * 014
 * 
 * Input:
 * 624 58
 * Output:
 * 672
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace _20210104paiza
{
    static class C061
    {
        // solution
        //public static void Run()
        //{
        //    // variables
        //    string large, small;
        //    string answer = "";

        //    // input
        //    string[] numbers = Console.ReadLine().Trim().Split(' ');

        //    // 
        //    if (int.Parse(numbers[0]) > int.Parse(numbers[1]))
        //    {
        //        large = numbers[0];
        //        small = numbers[1];
        //    }
        //    else
        //    {
        //        large = numbers[1];
        //        small = numbers[0];
        //    }

        //    // calculate from right to left
        //    for (int i = 0; i < large.Length; i++)
        //    {
        //        int lDigit = int.Parse((large[large.Length - i - 1]).ToString());
        //        int sDigit = small.Length - i - 1 < 0 ? 0 : int.Parse((small[small.Length - i - 1]).ToString());
        //        int digit = (lDigit + sDigit) % 10;

        //        // concatenate digits
        //        answer = digit + answer;
        //    }

        //    // output
        //    Console.WriteLine(answer);
        //}

        // solution
        public static void Run()
        {
            // variables
            string answer = "";
            int large, small;

            // input
            string[] numbers = Console.ReadLine().Trim().Split(' ');

            // 
            if (int.Parse(numbers[0]) > int.Parse(numbers[1]))
            {
                large = int.Parse(numbers[0]);
                small = int.Parse(numbers[1]);
            }
            else
            {
                large = int.Parse(numbers[1]);
                small = int.Parse(numbers[0]);
            }

            // calculate from right to left
            for (int i = 0; i < large / Math.Pow(10, i); i++)
            {
                int lDigit = (int)(large / Math.Pow(10, i)) % 10;
                int sDigit = (int)(small / Math.Pow(10, i)) % 10;
                int digit = (lDigit + sDigit) % 10;
                // concatenate digits
                answer = digit.ToString() + answer;
            }

            // output
            Console.WriteLine(answer);
        }

    }
}
