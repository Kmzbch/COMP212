/**
 * Input Value:
 * 
 * Input is given in the following format:
 * S
 * The password S is given in the first line as a string
 * The input is on a single line and contains a newline at the end.
 * Each value is passed from the standard input as a string.
 * 
 * Expected Output:
 * In order to prevent simple password input, print "NG" if all the characters of the password are the same. Otherwise, print "NG". 
 * Put a new line at the end. No extra characters or blank lines included.
 * 
 * Conditions:
 * All the testcases meet the following conditions:
 * 2 <= the length of string S <= 100
 * String S consists of alphanumeric
 * 
 * Examples:
 * Input:
 * AAAAAAA
 * Output:
 * NG
*
 * Input:
 * Paiza
 * Output:
 * OK
 */


using System;

namespace _20210103paiza
{
    static class D079
    {
        // straightforward implementation
        //public static void Run()
        //{
        //    // input
        //    string line = Console.ReadLine();
        //    bool validPassword = false;
        //    for (int i = 0; i < line.Length; i++)
        //    {
        //        if (i > 0)
        //        {
        //            if (line[i - 1] != line[i])
        //            {
        //                validPassword = true;
        //            }
        //        }
        //    }

        //    // output
        //    Console.WriteLine(validPassword ? "OK" : "NG");
        //}

        // alternative implementation
        public static void Run()
        {
            // input
            string line = Console.ReadLine();

            string first = line.Substring(0, line.Length - line.Length / 2);
            string last = line.Substring(line.Length / 2, line.Length - line.Length / 2);

            // output
            Console.WriteLine(first.Equals(last) ? "NG" : "OK");
        }

    }
}

