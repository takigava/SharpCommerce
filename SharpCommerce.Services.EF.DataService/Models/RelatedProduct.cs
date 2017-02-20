using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public partial class RelatedProduct
    {
        public RelatedProduct()
        {
            Product = new HashSet<Product>();
        }

        public int RelatedProductId { get; set; }
        public int MainProductId { get; set; }
        public int ChildProductId { get; set; }

        public virtual ICollection<Product> Product { get; set; }
        public virtual Product ChildProduct { get; set; }
        public virtual Product MainProduct { get; set; }
    }
}
