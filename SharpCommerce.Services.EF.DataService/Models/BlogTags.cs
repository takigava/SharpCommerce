using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class BlogTags
    {
        public int BlogTagsId { get; set; }
        public int BlogId { get; set; }
        public int TagId { get; set; }

        public virtual Blog Blog { get; set; }
        public virtual Tags Tag { get; set; }
    }
}
