/**
 * Input Value:
 * 
 * Input is given in the following format:
 * N M
 * Two candidate integers, N and M, are entered separated by a single space.
 * The input is on a single line and contains a newline at the end.
 * Each value is passed from the standard input as a string.
 * 
 * Expected Output:
 * Print "YES" if the two numbers N & M are a pair of an even number and an odd number. Otherwise, print "NO". 
 * Put a new line at the end. No extra characters or blank lines included.
 * 
 * Conditions:
 * All the testcases meet the following conditions:
 * 1 <= N, M <= 50
 * 
 * Examples:
 * Input:
 * 30 15
 * Output:
 * YES
*
 * Input:
 * 12 40
 * Output:
 * NO
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace _20210103paiza
{
    static class D101
    {
        //    // straightforward inplementation
        //    public static void Run()
        //    {
        //        string line1 = Console.ReadLine().Trim();
        //        string[] numbers = line1.Split(' ');

        //        bool containEvenNum = false;
        //        bool containOddNum = false;

        //        foreach (string s in numbers)
        //        {
        //            if (int.Parse(s) % 2 == 0)
        //            {
        //                containEvenNum = true;
        //            }
        //            else
        //            {
        //                containOddNum = true;
        //            }
        //        }
        //        if (containEvenNum && containOddNum)
        //        {
        //            Console.WriteLine("YES");
        //        }
        //        else
        //        {
        //            Console.WriteLine("NO");
        //        }
        //    }
        //}

        public static void Run()
        {
            // input
            string[] numbers = Console.ReadLine().Trim().Split(' ');

            // first for even, second for odd
            bool[] conditions = new bool[] { false, false };
            conditions[int.Parse(numbers[0]) % 2] = true;
            conditions[int.Parse(numbers[1]) % 2] = true;

            // output
            Console.WriteLine(conditions[0] && conditions[1] ? "YES" : "NO");
        }

    }
}
