using System;
using System.Collections.Generic;
using System.Text;

namespace _20210125paiza
{
    static class C035
    {
        public static void Run()
        {
            int n = int.Parse(Console.ReadLine().Trim());
            int passed = 0;

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Trim().Split(' ');
                int[] inputInts = Array.ConvertAll(new string[] { input[1], input[2], input[3], input[4], input[5] }, s => int.Parse(s));

                int sum = 0;
                Array.ForEach(inputInts, delegate (int k) { sum += k; });

                if (sum >= 350)
                {
                    // l/s
                    if (input[0] == "s")
                    {
                        if (inputInts[1] + inputInts[2] >= 160)
                        {
                            passed++;
                        }
                    }
                    else
                    {
                        if (inputInts[3] + inputInts[4] >= 160)
                        {
                            passed++;
                        }
                    }
                }
            }
            Console.WriteLine(passed);
    }

}
}
