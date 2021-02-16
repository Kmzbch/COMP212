using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _20210115Upchain
{
    class Person
    {
        // properties
        public Person Mother { get; set; }
        public Person Father { get; set; }
        public string Name { get; set; }

        // constructors
        public Person(string name)
        {
            Name = name;
        }

        // methods
        public void DepthFirstTraverse(TextWriter writer)
        {
            writer.WriteLine(Name);
            if(Mother != null || Father != null)
            {
                if (Mother != null)
                {
                    Mother.DepthFirstTraverse(writer);
                }
                if (Father != null)
                {
                    Father.DepthFirstTraverse(writer);
                }
            }
        }
        public void DepthFirstTraverse(Action<Person> action)
        {
            action.Invoke(this);
            if (Mother != null || Father != null)
            {
                if (Mother != null)
                {
                    Mother.DepthFirstTraverse(action);
                }
                if (Father != null)
                {
                    Father.DepthFirstTraverse(action);
                }
            }

        }

        public void BreadthFirstTraverse(TextWriter writer)
        {
            Queue<Person> q = new Queue<Person>();
            if (root != nil) q.(root);

            while (!q.isEmpty())
            {
                Person u = q.remove();
                if (Mother != null)
                {
                    writer.WriteLine(Mother.Name);
                }
                if (Father != null)
                {
                    writer.WriteLine(Father.Name);
                }
            }


            writer`a.WriteLine(Name);
            if (Mother != null || Father != null)
            {
                if (Mother != null)
                {
                    Mother.BreadthFirstTraverse(writer);
                }
                if (Father != null)
                {
                    Father.BreadthFirstTraverse(writer);
                }
            }



        }

    }
}
