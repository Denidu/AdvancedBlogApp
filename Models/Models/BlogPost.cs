// Models/BlogPost.cs

using System;
using System.Collections.Generic;

namespace AdvancedBlogApp.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public List<Comment> Comments { get; set; }
    }
}

