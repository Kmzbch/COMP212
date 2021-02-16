using System.Data.Entity;

namespace DemoCodeFirst_001
{
    public class BloggingDbContext : DbContext
    {
        // properties
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
