using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Question 2 										[5 marks]
/// Implement an extension method for class StringBuilder to count 
/// the number of words contained in a StringBuilder object. For example, 
/// if a StringBuilder object sb =”This is to test whether the extension method count 
/// can return a right answer or not”, the number of words contained in sb is 16.

/// </summary>
namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate string builder
            StringBuilder sb = new StringBuilder();
            
            // append string
            sb.Append("This is to test whether the extension method count can return a right answer or not");

            // diplay text and information
            Console.WriteLine(sb);

            Console.WriteLine($"Number of words: {sb.Count()}");
        }
    }
}
