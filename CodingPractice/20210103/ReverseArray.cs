using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210103
{
    /*
     * 14. Reverse array in place (solution)
     * Read more: https://javarevisited.blogspot.com/2017/07/top-50-java-programs-from-coding-Interviews.html#ixzz6KLbtWPoi
     */
    public static class ReverseArray
    {
        public static void Run()
        {
            // prompt user to enter the first number of the series to print out
            Console.Write("Enter numbers with spaces: ");
            string[] userInput = Console.In.ReadLine().Trim().Split(' ');

            for(int i = 0; i < userInput.Length / 2; i++)
            {
                swap(userInput, i, userInput.Length - i - 1);
            }

            Console.WriteLine(string.Join(' ', userInput));

        }

        // TODO: use extension method
        private static void swap(string[] array, int first, int second)
        {
            string temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }


    
}
