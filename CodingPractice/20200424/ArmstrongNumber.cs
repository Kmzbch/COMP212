using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 5. Armstrong number (solution)
 * A number is called an Armstrong number if it is equal to the cube of its every digit. 
 * For example, 153 is an Armstrong number because of 153= 1+ 125+27, which is equal to 1^3+5^3+3^3. 
 * You need to write a program to check if the given number is Armstrong number or not.
 * 
 * Read more: https://javarevisited.blogspot.com/2017/07/top-50-java-programs-from-coding-Interviews.html#ixzz6KXHkDgur
 */
namespace _20200424
{
    static class ArmstrongNumber
    {
        public static void Run()
        {
            Console.Out.Write("Enter Intger:");
            int number = int.Parse(Console.In.ReadLine());

            if (IsArmstrongNumber(number))
            {
                Console.WriteLine(number + " is an armstrong number");
            }
            else
            {
                Console.WriteLine(number + " is NOT an armstrong number");
            }
        }

        private static bool IsArmstrongNumber(int number)
        {
            //            *For example, 153 is an Armstrong number because of 153 = 1 + 125 + 27, which is equal to 1 ^ 3 + 5 ^ 3 + 3 ^ 3

            int dividend = number;
            int sum = 0;
            while (dividend > 0)
            {
                sum += (int) Math.Pow(dividend % 10, 3);
                dividend /= 10;
            }
            
            return number == sum ? true : false;
        }
    }
}
