using System;
using System.Collections.Generic;
using System.Text;

namespace _20210113paiza
{
    static class C051
    {
        public static void Run()
        {
            // input
            int[] numbers = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), s => int.Parse(s));

            // 0 -> ten's place 1 -> first place
            int[] digits = new int[2];

            digits[0] += numbers[0];

            for (int i=1; i < numbers.Length; i++)
            {
                digits[0] += numbers[i];

                for (int j=i+1; j < numbers.Length; j++)
                {
                    digits[0] += numbers[j];
                }
            }


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
