using System.Collections.Generic;

namespace DemoCodeFirst_001
{
    public class Blog
    {
        // properties
        public int BlogId { get; set; }
        public string Name { get; set; }
        public virtual List<Post> Posts { get;set;}
    }
}
