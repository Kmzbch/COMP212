/**
 * C084: handle name
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

namespace _20210105paiza
{
    static class C084
    {
        //// straight forward solution
        //public static void Run()
        //{
        //    // input
        //    string line = Console.ReadLine().Trim();

        //    char plus = '+';

        //    string enclosure = "+";
        //    for (int i = 0; i < line.Length; i++)
        //    {
        //        enclosure += plus;
        //    }
        //    enclosure += "+";

        //    Console.WriteLine(enclosure);
        //    Console.WriteLine(plus + line + plus);
        //    Console.WriteLine(enclosure);

        //}

        // simplest
        public static void Run()
        {
            // input
            string message = Console.ReadLine().Trim();
            string side = new string('+', 1 + message.Length + 1);

            Console.WriteLine(side);
            Console.WriteLine('+' + message + '+');
            Console.WriteLine(side);
        }

    }
}
