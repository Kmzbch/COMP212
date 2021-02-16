using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsExamples2
{
    public static class StringExtensions
    {
        public static int CharCount(this string str)
        {
            return str.Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Demonstration of Extension Methods";
            Console.WriteLine(name.CharCount());
        }
    }
}
