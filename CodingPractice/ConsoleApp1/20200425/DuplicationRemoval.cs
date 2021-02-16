using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1._20200425
{
    /*
     * 9. Remove duplicates from an array(solution)
     * Write a program to remove duplicates from an array in Java without using the Java Collection API.
     * The array can be an array of String, Integer or Character, your solution should be independent of the type of array.
     * If you want to practice more array-based questions, then see this list of top 30 array interview questions from Java interviews.
     * Top 50 Java Programs from Coding Interviews
     * https://javarevisited.blogspot.com/2017/07/top-50-java-programs-from-coding-Interviews.html#axzz6KMIhrBB5
    */
    static class DuplicationRemoval
    {
        public static void Run()
        {

            string[] array1 = new string[] { "alice", "bob", "cecil", "bob", "emily", "bob", "george" };

            // 
            Console.WriteLine("array1:");
            foreach (string str in array1)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();

            string[] array1Dash = RemoveDuplicationFromAnArrayWithMap(array1);
            Console.WriteLine("array1':");
            foreach (string str in array1Dash)
            {
                Console.Write(str + " ");
            }
            Console.WriteLine();

            // intager
            int[] array2 = new int[] { 1, 2, 3, 2, 4, 2, 5 };
            // 
            Console.WriteLine("array2:");
            foreach (int num in array2)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            int[] array2Dash = RemoveDuplicationFromAnArray(array2);
            Console.WriteLine("array2':");
            foreach (int num in array2Dash)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();


        }

        // straight forward implementation
        private static T[] RemoveDuplicationFromAnArray<T>(T[] arr)
        {
            T[] result = new T[arr.Length];
            int count = 0;

            foreach (T elem in arr)
            {
                for(int i=0; i < result.Length; i++)
                {
                    if (elem.Equals(result[i]))
                    {
                        break;
                    }
                    // compare to default value of the type
                    else if (Object.Equals(result[i], default(T)))
                    {
                        result[i] = elem;
                        count++;
                        break;
                    }
                }
            }

            // resize the result
            Array.Resize(ref result, count);
            
            return result;
        }

        /**
         * Implementation with dictionary or map
         */
        private static T[] RemoveDuplicationFromAnArrayWithMap<T>(T[] arr)
        {
            Dictionary<T, int> dict = new Dictionary<T, int>();

            foreach(T keyName in arr)
            {
                if (!dict.ContainsKey(keyName))
                {
                    dict.Add(keyName, 1);
                }
            }

            return dict.Keys.ToArray();
        }

    }
}
