using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Tags
    {
        public Tags()
        {
            BlogTags = new HashSet<BlogTags>();
            NewsTags = new HashSet<NewsTags>();
        }

        public int TagId { get; set; }
        public string Tag { get; set; }

        public virtual ICollection<BlogTags> BlogTags { get; set; }
        public virtual ICollection<NewsTags> NewsTags { get; set; }
    }
}
