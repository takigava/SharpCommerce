using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class NewsCategory
    {
        public NewsCategory()
        {
            News = new HashSet<News>();
        }

        public int NewsCategoryId { get; set; }
        public string Name { get; set; }
        public int? SortOrder { get; set; }

        public virtual ICollection<News> News { get; set; }
    }
}
