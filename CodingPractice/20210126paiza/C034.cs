using System;
using System.Collections.Generic;
using System.Text;

namespace _20210126paiza
{
    static class C034
    {
        public static void Run()
        {
            string[] input = Console.ReadLine().Trim().Split(' ');
            int result = 0;
            int op = input[1] == "-" ? (-1) : 1;

            if (input[0] == "x")
            {
                result = int.Parse(input[4]) - (int.Parse(input[2]) * op);
            }
            else if (input[2] == "x")
            {
                result = (int.Parse(input[4]) - int.Parse(input[0])) * op;
            }
            else if (input[4] == "x")
            {
                result = int.Parse(input[0]) + (int.Parse(input[2]) * op);
            }

            Console.WriteLine(result);
        }

}
}
