using System;

using System;
using System.Collections.Generic;
using System.Text;

/**
 * Bob is researching his family tree. His parents are Mary (female) and Fred(male).
 * His grandparents on his mother's side are Anne(female) and Mark(male).
 * His grandparents on his father's side are Jane(female) and John(male).
 * Bob wants you to write a program to help him traverse his family tree.
 * He wants to be able to do both breadth-first and depth-first traversals,
 * but when there is a choice he will always choose the mother's side before the father's side.
 * So if Bob wanted to produce a comma-separated list of all his ancestors
 * in depth first order, that would look like:
 * 
 * Bob, Mary, Anne, Mark, Fred, Jane, John
 * 
 * Help Bob and others try creating a program that traverses family trees.
 * 1. Define a Person class, with a Name, Mother and Father properties.
 * 2. Implement a DepthFirstTraverse method that accepts a TextWriter argument
 * and writes the Name of the Person and all their ancestors in depth first order, one per line
 * 3. Implement a DepthFirstTraverse overload that accepts an Action argument
 * and performs that action on each Person instead.
 * 4. Implement corresponding BreadFirstTraverse methods that operate as above
 * but in breadth first order
 */

namespace _20210115Upchain
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Bob")
            {
                Mother = new Person("Mary")
                {
                    Mother = new Person("Anne"),
                    Father = new Person("Mark")
                },
                Father = new Person("Fred")
                {
                    Mother = new Person("Jane"),
                    Father = new Person("John")
                }
            };         
//            person.DepthFirstTraverse(Console.Out);
            person.BreadthFirstTraverse(Console.Out);
        }
    }
}
