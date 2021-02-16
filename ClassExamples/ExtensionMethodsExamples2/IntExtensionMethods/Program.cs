using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntExtensionMethods
{
    public static class StringExtensions
    {
        public static int CharCount(this string str)
        {
            return str.Length;
        }
    }
    public static class IntExtensions
    {
        public static int SquareInt(this int num)
        {
            return num * num;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string name = "Demonstration of Extension Methods";
            Console.WriteLine(name.CharCount());

            int number = 3;
            Console.WriteLine(number.SquareInt());

        }
    }
}
