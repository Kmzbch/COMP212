using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20200424
{
    /*7. Factorial (solution)
     * This is one of the simplest programs you can expect in interviews. 
     * It is generally asked to see if you can code or not. 
     * Sometimes interviewer may also ask about changing a recursive solution to iterative one or vice-versa.
     * 
     * Read more: https://javarevisited.blogspot.com/2017/07/top-50-java-programs-from-coding-Interviews.html#ixzz6KXPUtUGQ
     */
    static class Factorial
    {
        public static void Run()
        {
            Console.Out.Write("Enter Intger:");
            int number = int.Parse(Console.In.ReadLine());

//                Console.WriteLine(number + "! = " + CalcFactorial(number));
            Console.WriteLine(number + "! = " + CalcFactorialRecursively(number));
        }

        private static int CalcFactorial(int number) {
            int result = 1;

            // iterative
            for(int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        private static int CalcFactorialRecursively(int number)
        {
            return number == 1 || number == 0 ? 1
                : CalcFactorialRecursively(number - 1) * number;
        }
    }
}
