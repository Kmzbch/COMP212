using System;

namespace _20200303AlphaLabs
{
    /* 
     *  Enter Starting Number: 10
     *  10
     *  5
     *  0
     *  5
     *  10
     *  
     *  Enter Starting Number: 9
     *  9
     *  4
     *  -1
     *  4
     *  9
     */
    static class Series
    {
        public static void Run()
        {
            // prompt user to enter the first number of the series to print out
            Console.Out.Write("Enter Starting Number: ");
            int userInput = Convert.ToInt32(Console.In.ReadLine());

            int difference = 5;

            PrintSeries(userInput, difference);
        }

        /*
         * 1. recursion is use
         * 2. the center ends up with less than or equal to 0 
         * 3. both ends get printed out
         */ 
        private static void PrintSeries(int input, int diff)
        {
            // create 
            int[] array = new int[] { input, input };

            // display the first number
            Console.WriteLine(array[0]);

            if (input > 0)
            {
                // display the numbers between second and second last recursively 
                PrintSeries(input - diff, diff);

                // display the last number
                Console.WriteLine(array[1]);
            }
        }

    }
}
