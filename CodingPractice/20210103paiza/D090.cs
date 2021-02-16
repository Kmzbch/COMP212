/**
 * Input Value:
 * 
 * Input is given in the following format:
 * a_1, a_2, a_3, a_4, a_5
 * Each of a_1, a_2, a_3, a_4, a_5 is an integer
 * The input is on a single line and contains a newline at the end.
 * Each value is passed from the standard input as a string.
 * 
 * Expected Output:
 * Print the last digit of the sum of a_1, a_2, a_3, a_4, a_5
 * Put a new line at the end. No extra characters or blank lines included.
 * 
 * Conditions:
 * All the testcases meet the following conditions:
 * a_1, a_2, a_3, a_4, a_5 are integers
 * 0 <= a_1, a_2, a_3, a_4, a_5 <= 100
 * 
 * Examples:
 * Input:
 * 1 9 8 9 12
 * Output:
 * 9
*
 * Input:
 * 1 1 1 1 6
 * Output:
 * 0
 */
using System;

namespace _20210103paiza
{
    static class D090
    {
        public static void Run()
        {
            // input
            string line = Console.ReadLine();
            int sum = 0;

            string[] numbers = line.Split(' ');
            foreach (string s in numbers)
            {
                sum += int.Parse(s);
            }

            // output
            Console.WriteLine(sum % 10);
        }
    }
}
