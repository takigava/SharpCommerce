using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class ProductBadge
    {
        public ProductBadge()
        {
            Product = new HashSet<Product>();
        }

        public int BadgeId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}
