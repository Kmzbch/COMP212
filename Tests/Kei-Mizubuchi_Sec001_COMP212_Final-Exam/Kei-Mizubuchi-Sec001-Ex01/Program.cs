using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kei_Mizubuchi_Sec001_Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            List<int> list = new List<int>(); //create a generic list of integers

            for (int i = 0; i < 10; i++)
            {
                list.Add(rnd.Next(1, 21));
            }

            //var evenNumbers = from i in list
            //        where i % 2 == 0
            //        orderby i
            //        select i;

            //var oddeNumbersMultipliedByFive = from i in list
            //                                  where i % 2 == 1
            //                                  orderby i
            //                                  select i * 5;

            var evenNumbers = list.Where(x => x % 2 == 0).OrderBy(x => x);
            var oddNumbersMultipliedByFive = list.Where(x => x % 2 == 1).Select(x => x * 5).OrderBy(x => x);




            Console.WriteLine("--- list ---");
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--- #1 even numbers ---");
            foreach (int i in evenNumbers)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("--- #2 odd numbers multiplied by five ---");
            foreach (int i in oddNumbersMultipliedByFive)
            {
                Console.WriteLine(i);
            }      
        }
    }
}
