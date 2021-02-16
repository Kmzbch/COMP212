/**
 * C056: Marks
 * 
 * Examples:
 * Input:
 * 5 25
 * 8 11
 * 20 1
 * 50 2
 * 70 0
 * 25 1
 * Output:
 * 1
 * 3
 * 4
*
 * Input:
 * 5 0 
 * 80 3
 * 70 4
 * 30 7
 * 60 1
 * 15 7
 * Output:
 * 1
 * 2
 * 3
 * 4
 * 5
 * 
 * Input:
 * 10 60
 * 85 3
 * 85 7
 * 65 1
 * 85 5
 * 90 0
 * 35 14
 * 10 1
 * 75 1
 * 25 3
 * 70 5
 * Output:
 * 1
 * 3
 * 4
 * 5
 * 8
 */


using System;
using System.Collections.Generic;
using System.Text;

namespace _20210108paiza
{
    static class C056
    {
        public static void Run()
        {
            // input
            string input = Console.ReadLine().Trim();
            int n = int.Parse(input.Split(' ')[0]);
            int m = int.Parse(input.Split(' ')[1]);
            bool[] studentsPassed = new bool[n];

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Trim();
                int marks = int.Parse(input.Split(' ')[0]);
                int absents = int.Parse(input.Split(' ')[1]);
                int deductedMarks = 0;
                if (marks - absents * 5 >= deductedMarks)
                {
                    deductedMarks = marks - absents * 5;
                }

                if (m <= deductedMarks)
                {
                    studentsPassed[i] = true;
                }
            }

            // output
            for (int i = 1; i <= studentsPassed.Length; i++)
            {
                if (studentsPassed[i - 1])
                {
                    Console.WriteLine(i);
                }
            }

        }
}
}
