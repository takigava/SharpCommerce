using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Blog
    {
        public Blog()
        {
            BlogComment = new HashSet<BlogComment>();
            BlogTags = new HashSet<BlogTags>();
        }

        public int BlogId { get; set; }
        public int BlogCategoryId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime PublishDate { get; set; }
        public string Picture { get; set; }
        public bool? IsCommentEnabled { get; set; }
        public string Slug { get; set; }

        public virtual ICollection<BlogComment> BlogComment { get; set; }
        public virtual ICollection<BlogTags> BlogTags { get; set; }
        public virtual BlogCategory BlogCategory { get; set; }
    }
}
