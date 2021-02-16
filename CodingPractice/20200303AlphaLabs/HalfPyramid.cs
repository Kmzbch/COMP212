using System;
using System.Text;

namespace _20200303AlphaLabs
{
    static class HalfPyramid
    {
        public static void Run()
        {
            // prompt user to enter the first number of the series to print out
            Console.Write("Enter Starting Number: ");
            int userInput = Convert.ToInt32(Console.In.ReadLine());

            PrintHalfPyramid(userInput);
        }

        private static void PrintHalfPyramid(int input)
        {
            StringBuilder sb = new StringBuilder("1");

            for(int i = 1; i <= input; i++)
            {
                if(i>1)
                {
                    sb.Insert(0, i + " ");
                }
                Console.WriteLine(sb);
            }

        }

    }
}
