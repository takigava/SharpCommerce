using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class Category
    {
        public Category()
        {
            ProductCategories = new HashSet<ProductCategories>();
        }

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public int? ParentCategoryId { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public int? SortOrder { get; set; }
        public bool? Enabled { get; set; }
        public string WebUrl { get; set; }
        public bool? DisplayFilter { get; set; }
        public bool? DisplayChildProducts { get; set; }
        public bool? DisplayThematicTabs { get; set; }
        public string DisplayStyle { get; set; }

        public virtual ICollection<ProductCategories> ProductCategories { get; set; }
    }
}
