using System;
using System.Collections.Generic;
using System.Text;

namespace _20210126paiza
{
    static class C074
    {
        public static void Run()
        {
            // 
            string[] input = Console.ReadLine().Trim().Split(' ');
            int h = int.Parse(input[0]);
            int w = int.Parse(input[1]);
            int x = int.Parse(input[2]);

            string textbody = "";

            // concatenete all the line
            for (int i = 0; i < h; i++)
            {
                textbody += Console.ReadLine().Trim();
            }

            for (int i = 0; i < textbody.Length; i++)
            {
                Console.Write(textbody[i]);
                if (i % x == x - 1)
                {
                    Console.WriteLine();
                }
            }

        }
}
}
