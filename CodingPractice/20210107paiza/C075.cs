/**
 * C075: Paying Fares by points
 * 
 * Examples:
 * Input:
 * 2000 5
 * 300
 * 500
 * 300
 * 100
 * 100
 * Output:
 * 1700 30
 * 1200 80
 * 900 110
 * 900 10
 * 800 20
*
 * Input:
 * 3000 3
 * 1000
 * 1000
 * 1000
 * Output:
 * 2000 100
 * 1000 200
 * 0 300
 */

using System;

namespace _20210107paiza
{
    static class C075
    {
        public static void Run()
        {
            // input
            string line = Console.ReadLine().Trim();
            int amount = int.Parse(line.Split(' ')[0]);
            int times = int.Parse(line.Split(' ')[1]);
            int points = 0;

            int[] fares = new int[times];
            for (int i = 0; i < times; i++)
            {
                fares[i] = int.Parse(Console.ReadLine().Trim());
            }

            // output
            foreach (int f in fares)
            {
                if (points < f)
                {
                    points += f / 10;
                    amount -= f;
                }
                else
                {
                    points -= f;
                }
                Console.WriteLine(amount + " " + points);
            }
        }
    }
}
