using System;
using System.Collections.Generic;
using System.Text;

namespace _20210115paiza
{
    static class C055
    {
        public static void Run()
        {

            // wrong answer
            int[] inputs = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), s => int.Parse(s));

            int profit = 0;
            int numOfStocks = 0;
            int price = 0;

            for (int i = 0; i < inputs[0]; i++)
            {
                price = int.Parse(Console.ReadLine().Trim());
                if (price <= inputs[1])
                {
                    profit -= price;
                    numOfStocks++;
                }
                else if (price >= inputs[0])
                {
                    profit += numOfStocks * price;
                    numOfStocks = 0;
                }
            }

            if (numOfStocks > 0)
            {
                profit += numOfStocks * price;
            }

            Console.WriteLine(profit);
        }

    }
}
