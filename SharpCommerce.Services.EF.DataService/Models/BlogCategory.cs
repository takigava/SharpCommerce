using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class BlogCategory
    {
        public BlogCategory()
        {
            Blog = new HashSet<Blog>();
        }

        public int BlogCategoryId { get; set; }
        public string Name { get; set; }
        public int? SortOrder { get; set; }

        public virtual ICollection<Blog> Blog { get; set; }
    }
}
