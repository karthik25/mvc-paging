using System.Collections.Generic;

namespace MvcPaging.Models
{
    public class PostViewModel
    {
        public List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string PostTitle { get; set; }
        public string Category { get; set; }
    }
}