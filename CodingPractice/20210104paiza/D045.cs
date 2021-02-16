/**
 * 
 * Input Value:
 * 
 * Input is given in the following format:
 * N
 * Integer N which is to be converted from an numerical grade, are entered.
 * The input is on a single line and contains a newline at the end.
 * Each value is passed from the standard input as a string.
 * 
 * Expected Output:
 * Print the alphabetical letter grade converted on a single line.
 * Put a new line at the end. No extra characters or blank lines included.
 * 
 * Conditions:
 * All the testcases meet the following conditions:
 * 1 <= N <= 5
 * 
 * Examples:
 * Input:
 * 5
 * Output:
 * A
*
 * Input:
 * 3
 * Output:
 * C
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace _20210104paiza
{
    static class D045
    {
        public static void Run()
        {
            // input
            string line = Console.ReadLine().Trim();

            // cast
            int numericGrade = int.Parse(line);

            // conversion table
            char[] letterGrades = new char[]{
                'E',
                'D',
                'C',
                'B',
                'A'
            };

            // output
            Console.WriteLine(letterGrades[(numericGrade - 1) % 5]);
        }
    }

}
