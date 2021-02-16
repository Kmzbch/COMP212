using System;
using System.Collections.Generic;
using System.Text;

namespace _20210108paiza
{

static class B079
    {
        public static void Run()
        {
            // input
            string line = Console.ReadLine().Trim();
            string s = line.Split(' ')[0].ToUpper();
            string t = line.Split(' ')[1].ToUpper();

            // make series
            int[] seriesS = new int[s.Length];
            int[] seriesT = new int[t.Length];
            for (int i = 0; i < s.Length; i++)
            {
                seriesS[i] = s[i] - 64;
            }
            for (int i = 0; i < t.Length; i++)
            {
                seriesT[i] = t[i] - 64;
            }


            int[] series = new int[seriesS.Length + seriesT.Length];
            seriesS.CopyTo(series, 0);
            seriesT.CopyTo(series, seriesS.Length);

            // calc 1
            int affinity1 = calculateAffinity(series);

            // calc 2
            int[] seriesReversed = new int[seriesS.Length + seriesT.Length];
            seriesT.CopyTo(seriesReversed, 0);
            seriesS.CopyTo(seriesReversed, seriesT.Length);

            int affinity2 = calculateAffinity(seriesReversed);

            // comparison
            Console.WriteLine(affinity1 > affinity2 ? affinity1 : affinity2);

        }

        // recursive
        static private int calculateAffinity(int[] series)
        {
            return calcRecursively(series)[0];
        }

        static private int[] calcRecursively(int[] series)
        {
            if (series.Length == 1)
            {
                return series;
            }
            else
            {
                int[] subSeries = new int[series.Length - 1];
                for (int i = 0; i < series.Length - 1; i++)
                {
                    subSeries[i] = series[i] + series[i + 1];
                    if (subSeries[i] > 101)
                    {
                        subSeries[i] -= 101;
                    }
                }
                return calcRecursively(subSeries);
            }
        }
    }

}
