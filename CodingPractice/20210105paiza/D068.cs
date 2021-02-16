/**
 * D068: The Record of Sunny day and Rainny day
 * You are analyzing the weather logged 
 * Input Value:
 * 
 * Input is given in the following format:
 * n
 * s
 * The length of a string is entered on the first line.
 * A string of n length is given on a single line. "S" for a sunny day and "R" for rainny day
 * The input is on two lines and contains a newline at the end.
 * Each value is passed from the standard input as a string.
 * 
 * Expected Output:
 * Print the number of sunny days and rainny days separated by a single space.
 * Put a new line at the end. No extra characters or blank lines included.
 * 
 * Conditions:
 * All the testcases meet the following conditions:
 * n is an integer
 * String s is n long and consists of "S" and "R"
 * 1 <= n <= 100
 * 
 * Examples:
 * Input:
 * 5
 * SSRSR
 * Output:
 * 3 2
*
 * Input:
 * 10
 * SSSSSSSSSS
 * Output:
 * 10 0
 */

using System;
using System.Collections.Generic;
using System.Text;

namespace _20210105paiza
{
    static class D068
    {
        //
        //public static void Run()
        //{
        //    // variables
        //    var dict = new Dictionary<char, int>(){
        //        {'S', 0},
        //        {'R', 0}
        //    };

        //    // inputs
        //    int length = int.Parse(Console.ReadLine().Trim());
        //    string line = Console.ReadLine().Trim();

        //    // 
        //    for (int i = 0; i < length; i++)
        //    {
        //        dict[line[i]]++;
        //    }

        //    // output
        //    Console.WriteLine(dict['S'] + " " + dict['R']);
        //}

        // alternative
        public static void Run()
        {
            // inputs
            int n = int.Parse(Console.ReadLine().Trim());
            string str = Console.ReadLine().Trim();
            int numOfSunnyDays = 0;

            foreach(char c in str)
            {
                if (c == 'S')
                {
                    numOfSunnyDays++;
                }
            }

            // output
            Console.WriteLine(numOfSunnyDays + " " + (n - numOfSunnyDays));
        }

    }

}
