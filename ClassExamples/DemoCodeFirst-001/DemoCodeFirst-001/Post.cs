namespace DemoCodeFirst_001
{
    public class Post
    {
        // properties
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}
