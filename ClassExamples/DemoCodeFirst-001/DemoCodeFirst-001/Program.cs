using System;
using System.Linq;

namespace DemoCodeFirst_001
{
    class Program
    {
        static void Main(string[] args)
        {
            // instanciate DB context
            var db = new BloggingDbContext();
            Console.WriteLine("Enter a name for a new Blog:");
            var name = Console.ReadLine();

            // add blog to db context and reflect changes
            var blog = new Blog { Name = name };
            db.Blogs.Add(blog);
            db.SaveChanges();

            // select blogs with Linq
            var query = from b in db.Blogs orderby name select b;

            // display the result
            Console.WriteLine("All blogs in the database:");
            foreach (var item in query)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }
    }
}
