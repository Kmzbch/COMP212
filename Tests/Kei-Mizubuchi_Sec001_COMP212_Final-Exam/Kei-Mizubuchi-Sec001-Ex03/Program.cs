using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kei_Mizubuchi_Sec001_Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            int[] values = Enumerable.Range(1, 10000000)
                                     .Select(x => 2 * random.Next(0, 5) + 1)
                                     .ToArray();

            //foreach (int i in values)
            //{
            //    Console.WriteLine(i);
            //}

            // time the Min, Max and Average PLINQ extension methods
            Console.WriteLine(
               "\nMin, Max and Average with PLINQ using multiple cores");
            var plinqStart = DateTime.Now; // get time before method calls
            var plinqMin = values.AsParallel().Min();
            var plinqMax = values.AsParallel().Max();
            var plinqAverage = values.AsParallel().Average();
            var plinqEnd = DateTime.Now; // get time after method calls

            // display results and total time in milliseconds
            var plinqTime = plinqEnd.Subtract(plinqStart).TotalMilliseconds;
            DisplayResults(plinqMin, plinqMax, plinqAverage, plinqTime);

        }

        // displays results and total time in milliseconds
        static void DisplayResults(
           int min, int max, double average, double time)
        {
            Console.WriteLine($"Min: {min}\nMax: {max}\n" +
               $"Average: {average:F}\nTotal time in milliseconds: {time:F}");
        }

    }
}
