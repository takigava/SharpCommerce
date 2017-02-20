using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class ProductCategories
    {
        public int ProductCategoriesId { get; set; }
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public int? SortOrder { get; set; }
        public bool? IsMainCategory { get; set; }

        public virtual Category Category { get; set; }
        public virtual Product Product { get; set; }
    }
}
