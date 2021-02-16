/**
 * C086: Enclose a string with a frame
 * You are sending your friend an message...
 * Input Value:
 * 
 * Input is given in the following format:
 * s
 * String S to send enclosed by frame is entered on the first line.
 * The input is on two lines and contains a newline at the end.
 * Each value is passed from the standard input as a string.
 * 
 * Expected Output:
 * Print the string to send enclosed by a frame
 * Put a new line at the end. No extra characters or blank lines included.
 * 
 * Conditions:
 * All the testcases meet the following conditions:
 * String consists of alphabets
 * 1 <= (the length of S) <= 100
 * 
 * Examples:
 * Input:
 * Paiza
 * Output:
 * +++++++
 * +Paiza+
 * +++++++
*
 * Input:
 * TicTacToe
 * Output:
 * +++++++++++
 * +TicTacToe+
 * +++++++++++
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _20210105paiza
{
    static class C086
    {
        // simplest solution
        //public static void Run()
        //{
        //    // input
        //    string name = Console.ReadLine().Trim();
        //    string handleName = Regex.Replace(name, @"[aeiouAEIOU]", "");
        //    Console.WriteLine(handleName);
        //}

        // solution without Regex
        public static void Run()
        {
            // input
            string name = Console.ReadLine().Trim();

            string handleName = "";

            foreach(char c in name)
            {
                if (c != 'A' && c != 'a'
                    && c != 'E' && c != 'e'
                    && c != 'I' && c != 'i'
                    && c != 'O' && c != 'o'
                    && c != 'U' && c != 'u')
                {
                    handleName += c;
                }
            }
            Console.WriteLine(handleName);
        }

    }
}
