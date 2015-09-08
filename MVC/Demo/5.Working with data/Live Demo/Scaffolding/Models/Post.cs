using System;

namespace Scaffolding.Models
{
    public class Post
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }

        public int Votes { get; set; }

        public bool IsApproved { get; set; }

        public PostType Type { get; set; }
    }
}